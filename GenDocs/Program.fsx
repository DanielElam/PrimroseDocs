open System
open System.IO
open System.Text
open System.Linq
open System.Collections.Generic
open System.Reflection
open System.Xml
open Newtonsoft.Json
open System.Text.RegularExpressions

let slnDir = "../../../../"
let docsDir = Path.GetFullPath("../../../hugo/content/en/docs/api-reference")
#if DEBUG
let dllFile = Path.Combine(slnDir, "Engine", "bin", "Win64", "Debug", "Engine.dll")
let xmlFile = Path.Combine(slnDir, "Engine", "bin", "Win64", "Debug", "Engine.xml")
#else
let dllFile = Path.Combine(slnDir, "Engine", "bin", "Win64", "Release", "Engine.dll")
let xmlFile = Path.Combine(slnDir, "Engine", "bin", "Win64", "Release", "Engine.xml")
#endif

let baseURL = ""

type ApiType = {
    Category: string
    Name: string
    Generics: ApiType[]
    IsGeneric: bool
} with
    member this.CleanName = begin
        if this.IsGeneric then
            this.Name.Substring(0, this.Name.IndexOf('`'))
        else
            let result = this.Name
            match result with
            | "Object" -> "object"
            | "Void" -> "void"
            | "Boolean" -> "bool"
            | "String" -> "string"
            | "Char" -> "char"
            | "Byte" -> "byte"
            | "SByte" -> "sbyte"
            | "Int16" -> "int16"
            | "UInt16" -> "uint16"
            | "Int32" -> "int"
            | "UInt32" -> "uint"
            | "Int64" -> "long"
            | "UInt64" -> "ulong"
            | "Single" -> "float32"
            | "Double" -> "double"
            | "BigInt" -> "bigint"
            | "Decimal" -> "decimal"
            | _ -> result
    end
    member this.ToString() = begin
        if this.IsGeneric then
            this.CleanName + "<" + String.Join(", ", this.Generics.Select(fun i -> i.ToString())) + ">"
        else
            this.Name
    end

type ApiCommentParam = {
    Name: string
    Text: string
}

type ApiComment = {
    Summary: string
    Remarks: string
    Params: ApiCommentParam[]
}

type ApiEnumItem = {
    Name: string
    Value: int64
    Comment: ApiComment
}

type ApiEnum = {
    Name: string
    Items: ApiEnumItem[]
    Comment: ApiComment
}

type ApiParameter = {
    Name: string
    Type: ApiType
    Default: string
}

type PropertySecurity = {
    Read: string
    Write: string
}

type PropertySerialization = {
    CanLoad: bool
    CanSave: bool
}

type ApiProperty = {
    MemberType: string
    Name: string
    ValueType: ApiType
    Security: PropertySecurity
    Comment: ApiComment
    Tags: string[]
}

type ApiFunction = {
    MemberType: string
    Name: string
    Parameters: ApiParameter[]
    ReturnType: ApiType
    Security: string
    Comment: ApiComment
    Generics: string[]
    Tags: string[]
} with
    member this.IsGeneric = begin
        this.Generics <> null
    end

type ApiEvent = {
    MemberType: string
    Name: string
    Parameters: ApiParameter[]
    Security: PropertySecurity
    Comment: ApiComment
    Tags: string[]
}

type ApiClass = {
    Name: string
    MemoryCategory: string
    Superclass: string
    Tags: string[]
    Members: obj[]
    TypeId: int
    ExplorerImage: string
    Comment: ApiComment
    FullName: string
}

type ApiRoot = {
    Classes: ApiClass[] 
    DataTypes: ApiClass[] 
    Assets: ApiClass[] 
    Enums: ApiEnum[] 
}

let GetTypesSafely(assembly: Assembly) = begin
    try
        assembly.GetTypes() :> IEnumerable<Type>
    with
        | :? ReflectionTypeLoadException as ex -> ex.Types.Where(fun x -> x <> null)
end

let assembly = typeof<Primrose.GameEngine>.Assembly

let types = GetTypesSafely(assembly)

let commentDictionary = new Dictionary<string, ApiComment>()
let commentTypeDictionary = new Dictionary<string, obj>()
let docsXml = new XmlDocument()
docsXml.Load(xmlFile)
let members = docsXml.GetElementsByTagName("members").[0]
for mem in members.ChildNodes do
    if (mem.NodeType <> XmlNodeType.Comment) then begin
        let summary = mem.SelectSingleNode("summary")
        let remarks = mem.SelectSingleNode("remarks")
        let paras = mem.SelectNodes("param")
        commentDictionary.Add(mem.Attributes.["name"].Value, {
            Summary = if summary <> null then summary.InnerXml else null
            Remarks = if remarks <> null then remarks.InnerXml else null
            Params = if paras.Count = 0 then Array.empty<ApiCommentParam> else [for i=0 to paras.Count-1 do yield { Name = paras.Item(i).Name; Text = paras.Item(i).InnerXml }].ToArray()
        })
    end
done

let AssetType = types.FirstOrDefault(fun n -> n.FullName = "Primrose.Assets.Asset")
let DataType = types.FirstOrDefault(fun n -> n.FullName = "Primrose.IDataType")
let InstanceType = types.FirstOrDefault(fun n -> n.FullName = "Primrose.DataModel.Instance")
let TypeIdAttributeType = types.FirstOrDefault(fun n -> n.FullName = "Primrose.DataModel.Attributes.TypeIdAttribute")
let ExplorerImageAttributeType = types.FirstOrDefault(fun n -> n.FullName = "Primrose.DataModel.Attributes.ExplorerImageAttribute")
let NotBrowsableAttributeType = types.FirstOrDefault(fun n -> n.FullName = "Primrose.DataModel.Attributes.NotBrowsableAttribute")
let ScriptSecurityAttributeType = types.FirstOrDefault(fun n -> n.FullName = "Primrose.DataModel.Attributes.ScriptSecurityAttribute")
let YieldFunctionAttributeType = types.FirstOrDefault(fun n -> n.FullName = "Primrose.DataModel.Attributes.YieldFunctionAttribute")
let ObsoleteAttributeType = typeof<ObsoleteAttribute>

assert(AssetType <> null)
assert(DataType <> null)
assert(InstanceType <> null)
assert(TypeIdAttributeType <> null)
assert(ExplorerImageAttributeType <> null)
assert(NotBrowsableAttributeType <> null)
assert(ScriptSecurityAttributeType <> null)
assert(YieldFunctionAttributeType <> null)
assert(ObsoleteAttributeType <> null)

let rec GetApiType(t: Type): ApiType = begin
    if (t.IsArray) then
        { Name = t.Name; Category = "Array"; Generics = [|GetApiType(t.GetElementType())|]; IsGeneric = false; }
    else
        let isPrimitive = t.IsPrimitive
        let isNone = t.FullName = null
        let isSystem = t.FullName <> null && t.FullName.StartsWith "System"
        let isEnum = t.IsEnum && t.FullName.StartsWith("Primrose.Enum.")
        let isAsset = AssetType.IsAssignableFrom(t)
        let isDataType = DataType.IsAssignableFrom(t)
        let isInstance = InstanceType.IsAssignableFrom(t)

        let isGeneric = t.IsGenericType
        let generics = if isGeneric then t.GetGenericArguments().Select(fun i -> GetApiType(i)).ToArray() else null

        if isNone then
            { Name = t.Name; Category = "None"; Generics = generics; IsGeneric = isGeneric; }
        elif isPrimitive then
            { Name = t.Name; Category = "Primitive"; Generics = generics; IsGeneric = isGeneric; }
        elif isSystem then
            { Name = t.Name; Category = "System"; Generics = generics; IsGeneric = isGeneric; }
        elif isEnum then
            { Name = t.Name; Category = "Enum"; Generics = generics; IsGeneric = isGeneric; }
        elif isAsset then
            { Name = t.Name; Category = "Asset"; Generics = generics; IsGeneric = isGeneric; }
        elif isDataType then
            { Name = t.Name; Category = "DataType"; Generics = generics; IsGeneric = isGeneric; }
        elif isInstance then
            { Name = t.Name; Category = "Class"; Generics = generics; IsGeneric = isGeneric; }
        elif t.IsPrimitive then
            { Name = t.Name; Category = "Primitive"; Generics = generics; IsGeneric = isGeneric; }
        else
            { Name = t.Name; Category = "Misc"; Generics = generics; IsGeneric = isGeneric; }
end
    
let DumpAPI(): ApiRoot = begin
    let classes = new List<ApiClass>()
    let assets = new List<ApiClass>()
    let enums = new List<ApiEnum>()
    let events = new List<ApiEvent>()

    let test = typeof<Primrose.DataModel.Networking.NetworkClient>
    let test2 = typeof<Primrose.DataModel.Networking.NetworkServer>

    for t in types do
        let isEnum = t.IsEnum && t.FullName.StartsWith("Primrose.Enum.")
        let isAsset = AssetType.IsAssignableFrom(t)
        let isDataType = DataType.IsAssignableFrom(t)
        let isInstance = InstanceType.IsAssignableFrom(t)

        let isValid = t.IsPublic && (isEnum || isAsset || isDataType || isInstance)
        if (isValid) then begin
            if (isEnum) then begin
                let commentId = sprintf "T:%s" t.FullName
                let hasComment, comment = commentDictionary.TryGetValue(commentId)
                let names = Enum.GetNames(t)
                let values = Enum.GetValues(t)
                let items:ApiEnumItem[] = Array.zeroCreate(names.Length)
                for i=0 to names.Length-1 do
                    let commentId = sprintf "F:%s.%s" t.FullName names.[i]
                    let hasComment, comment = commentDictionary.TryGetValue(commentId)
                    items.[i] <- {
                        Name = names.[i]
                        Value = Convert.ToInt64(values.GetValue(i))
                        Comment = if hasComment then comment else { Summary = null; Remarks = null; Params = null; }
                    }
                done
                enums.Add({
                    Name = t.Name
                    Items = items
                    Comment = if hasComment then comment else { Summary = null; Remarks = null; Params = null; }
                })
            end
            if (isInstance || isAsset) then begin
                let tags = new List<string>()
                let members = new List<obj>()

                for m in t.GetMembers(BindingFlags.Instance ||| BindingFlags.Public ||| BindingFlags.DeclaredOnly) do
                    let yieldFunctionAttr = m.GetCustomAttribute(YieldFunctionAttributeType)
                    let obsoleteAttr = m.GetCustomAttribute(ObsoleteAttributeType)
                    let notBrowsableAttr = m.GetCustomAttribute(NotBrowsableAttributeType)
                    
                    let mtags = new List<string>()
                    
                    if (obsoleteAttr <> null) then
                        mtags.Add "Deprecated"

                    // TODO: hide overriden properties & methods like CFrame in PVInstance inheritors
                    match m.MemberType with
                        | MemberTypes.Method -> begin
                                let methodInfo = m :?> MethodInfo
                                if (not methodInfo.IsSpecialName) then begin
                                    let retType = GetApiType(methodInfo.ReturnType)
                                    let mutable paramTypeStr = String.Join(',', methodInfo.GetParameters().Select(fun i -> i.ParameterType.FullName).ToArray())
                                    
                                    if (paramTypeStr <> "") then paramTypeStr <- "("+paramTypeStr+")"
                                    
                                    let commentId = sprintf "M:%s.%s%s" methodInfo.DeclaringType.FullName methodInfo.Name paramTypeStr
                                    let hasComment, comment = commentDictionary.TryGetValue(commentId)

                                    let generics = if methodInfo.IsGenericMethod then
                                                       methodInfo.GetGenericArguments().Select(fun g -> g.Name).ToArray()
                                                   else
                                                       null

                                    let apiMethod:ApiFunction = {
                                        MemberType = if yieldFunctionAttr <> null then "YieldFunction" else "Function"
                                        Name = m.Name
                                        ReturnType = retType
                                        Comment = if hasComment then comment else { Summary = null; Remarks = null; Params = null }
                                        Security = "None"
                                        Generics = generics
                                        Tags = mtags.ToArray()
                                        Parameters = methodInfo
                                            .GetParameters()
                                            .Select(fun param ->
                                                let paramType = GetApiType(param.ParameterType)
                                                {
                                                    Name = param.Name
                                                    Type = paramType
                                                    Default = 
                                                        if param.HasDefaultValue then
                                                            if param.DefaultValue = null then 
                                                                "null" 
                                                            elif param.ParameterType = typeof<String> then
                                                                "\"" + param.DefaultValue.ToString() + "\""
                                                            else param.DefaultValue.ToString()
                                                        else 
                                                            null

                                                }
                                            ).ToArray()                        
                                    }

                                    commentTypeDictionary.[commentId] <- apiMethod

                                    if (notBrowsableAttr = null) then
                                        members.Add(apiMethod)
                                end
                            end
                        | MemberTypes.Property -> begin
                                let propertyInfo = m :?> PropertyInfo
                                if (not propertyInfo.IsSpecialName) then begin
                                    let retType = GetApiType(propertyInfo.PropertyType)
                                    let commentId = sprintf "P:%s.%s" propertyInfo.DeclaringType.FullName propertyInfo.Name
                                    let hasComment, comment = commentDictionary.TryGetValue(commentId)

                                    let apiProperty:ApiProperty = {
                                        MemberType = "Property"
                                        Name = m.Name
                                        ValueType = retType
                                        Comment = if hasComment then comment else { Summary = null; Remarks = null; Params = null }
                                        Security = {
                                            Read = "None"
                                            Write = "None"
                                        }
                                        Tags = mtags.ToArray()
                                    }
                                    
                                    commentTypeDictionary.[commentId] <- apiProperty
                                    
                                    if (notBrowsableAttr = null) then
                                        members.Add(apiProperty)
                                end
                            end
                        | MemberTypes.Field -> begin
                                let fieldInfo = m :?> FieldInfo
                                if (fieldInfo.FieldType.FullName.StartsWith "Primrose.Signal") then begin
                                    let retType = GetApiType(fieldInfo.FieldType)
                                    let commentId = sprintf "F:%s.%s" fieldInfo.DeclaringType.FullName fieldInfo.Name
                                    let hasComment, comment = commentDictionary.TryGetValue(commentId)

                                    let parameters = if retType.Generics = null then Seq.empty<ApiParameter> else seq {
                                        for i=0 to retType.Generics.Length-1 do
                                            yield {
                                                Name = if (hasComment && i < comment.Params.Length) then comment.Params.[i].Text else ("p"+i.ToString());
                                                Type = retType.Generics.[i];
                                                Default = "";
                                            }
                                    }

                                    let apiEvent:ApiEvent = {
                                        MemberType = "Event"
                                        Name = m.Name
                                        Parameters = parameters.ToArray()
                                        Comment = if hasComment then comment else { Summary = null; Remarks = null; Params = null }
                                        Security = {
                                            Read = "None"
                                            Write = "None"
                                        }
                                        Tags = mtags.ToArray()
                                    }
                                
                                    commentTypeDictionary.[commentId] <- apiEvent
                                
                                    if (notBrowsableAttr = null) then
                                        members.Add(apiEvent)
                                end
                            end
                        | _ -> ignore()
                done

                let obsoleteAttr = t.GetCustomAttribute(ObsoleteAttributeType)
                let typeIdAttr = t.GetCustomAttribute(TypeIdAttributeType)
                let explorerImageAttr = t.GetCustomAttribute(ExplorerImageAttributeType)
                let notBrowsableAttr = t.GetCustomAttribute(NotBrowsableAttributeType)
                let scriptSecurityAttr = t.GetCustomAttribute(ScriptSecurityAttributeType)

                let typeId:UInt16 = 
                    if not (isNull(typeIdAttr)) then 
                        TypeIdAttributeType.GetProperty("Id").GetValue(typeIdAttr) :?> UInt16
                    else
                        UInt16.MaxValue

                let explorerImage = 
                    if not (isNull(explorerImageAttr)) then 
                        ExplorerImageAttributeType.GetProperty("Image").GetValue(explorerImageAttr) :?> string
                    else
                        "default"
                    
                if not (isNull(obsoleteAttr)) then
                    tags.Add "Deprecated"

                if not (isNull(notBrowsableAttr)) then
                    tags.Add "NotBrowsable"              

                let commentId = sprintf "T:%s" t.FullName
                
                let hasComment, comment = commentDictionary.TryGetValue(commentId)

                let apiClass:ApiClass = {
                    Name = t.Name
                    MemoryCategory = if isAsset then "Asset" else "Class"
                    Superclass = t.BaseType.FullName
                    Tags = tags.ToArray()
                    Members = members.ToArray()
                    TypeId = (int)typeId
                    ExplorerImage = explorerImage
                    Comment = if hasComment then comment else { Summary = null; Remarks = null; Params = null }
                    FullName = t.FullName
                }

                commentTypeDictionary.[commentId] <- apiClass

                if (notBrowsableAttr = null) then begin
                    if (isAsset) then (
                        assets.Add(apiClass)
                    )
                    else (
                        classes.Add(apiClass)
                    )
                end
            end
        end
    done

    { Classes = classes.ToArray(); Assets = assets.ToArray(); Enums = enums.ToArray(); DataTypes = null; }
end

let GetParentType(propertyId: string) = begin

    let b = propertyId.LastIndexOf("(")
    let lastIndex = if (b = -1) then propertyId.LastIndexOf(".") else propertyId.LastIndexOf(".", b)
        

    let replaced = propertyId.Replace("M:", "T:").Replace("P:", "T:").Replace("F:", "T:").Substring(0, lastIndex)

    let result, apiObj = commentTypeDictionary.TryGetValue(replaced)

    apiObj :?> ApiClass
end

let GetHrefFromReflectionId(reflectionId: string) = begin
    let result, apiObj = commentTypeDictionary.TryGetValue(reflectionId)
    if not result then
        reflectionId, reflectionId
    else
        if reflectionId.StartsWith("T:") then
            let apiClass = apiObj :?> ApiClass
            let result = sprintf "%s/docs/api-reference/%s/%s/" baseURL apiClass.MemoryCategory apiClass.Name
            result, apiClass.Name
        elif reflectionId.StartsWith("M:") then
            let apiFunction = apiObj :?> ApiFunction
            let parentType = GetParentType(reflectionId)
            let result = sprintf "%s/docs/api-reference/%s/%s/%s" baseURL parentType.MemoryCategory parentType.Name apiFunction.Name
            result, apiFunction.Name
        elif reflectionId.StartsWith("P:") then
            let apiProperty = apiObj :?> ApiProperty
            let parentType = GetParentType(reflectionId)
            let result = sprintf "%s/docs/api-reference/%s/%s/%s" baseURL parentType.MemoryCategory parentType.Name apiProperty.Name
            result, apiProperty.Name
        elif reflectionId.StartsWith("F:") then
            if (apiObj :? ApiProperty) then
                let apiProperty = apiObj :?> ApiProperty
                let parentType = GetParentType(reflectionId)
                let result = sprintf "%s/docs/api-reference/%s/%s/%s" baseURL parentType.MemoryCategory parentType.Name apiProperty.Name
                result, apiProperty.Name
            else
                let apiEvent = apiObj :?> ApiEvent
                let parentType = GetParentType(reflectionId)
                let result = sprintf "%s/docs/api-reference/%s/%s/%s" baseURL parentType.MemoryCategory parentType.Name apiEvent.Name
                result, apiEvent.Name
        else
            reflectionId, reflectionId
end


let FormatSummary(summary: string) = begin
    let evaluator = MatchEvaluator(fun m -> begin
        let reflectionId = m.Groups.[2].Value.Substring(0, m.Groups.[2].Value.LastIndexOf('"'))
        let href, name = GetHrefFromReflectionId(reflectionId)
        let a = m.Value.Replace(reflectionId, href)
                                .Replace("see", "a")
                                .Replace("cref", "href")
                                .Replace("/>", ">" + name + "</a>")
        a
    end)
    let regex = new Regex("<see\s+(?:[^>]*?\s+)?cref=([\"'])(.*?)\1*(\/>)")

    let summaryMod = String.Join("\r\n", summary.Split("\r\n").Select(fun n -> n.TrimStart()))
                        .Replace("&lt;", "<")
                        .Replace("&gt;", ">")

    regex.Replace(summaryMod, evaluator)
end

let buildInheritance(descendant: ApiClass, root: ApiRoot) = begin
    let sb = new StringBuilder()
    sb.AppendLine "<small class=\"inheritance\">"

    let mutable current = Some(descendant)

    while (current.IsSome) do 
        if (current.Value <> descendant) then
            sb.Append("&nbsp;:&nbsp;") |> ignore
        let tag = if (current.Value <> descendant) then "a" else "span"
        let className = if current.Value.Tags.Contains "Deprecated" then "deprecated" else ""
        sb.Append("<"+tag+" class=\""+className+"\" href=\""+baseURL+"/docs/api-reference/Class/"+current.Value.Name+"\">")
        sb.Append("<img src=\""+baseURL+"/icons/silk/"+current.Value.ExplorerImage+".png\"/>")
        sb.Append "&nbsp;"
        sb.Append(current.Value.Name)
        sb.Append("</"+tag+">")
        current <- if (current.Value.Superclass = null) then 
                       None 
                   else 
                       let superClass = box(root.Classes.FirstOrDefault(fun c -> c.FullName = current.Value.Superclass))
                       match superClass with
                       | null -> None
                       | _ -> Some(unbox superClass)

    sb.Append "</small>"

    sb.ToString()
end

let rec buildType(t: ApiType, pageClass: ApiClass): string = begin
    let sb = new StringBuilder()
    if (t.CleanName = "ValueTuple") then
        sb.Append "<div class=\"tuple\">"
        sb.Append("<a class=\"type\" href=\""+baseURL+"/docs/api-reference/"+t.Category+"/"+t.CleanName+"\">")
        sb.Append("</a>")
        sb.Append "("
        let mutable first = true
        for g in t.Generics do
            if not (first) then begin
                sb.Append(", ")
                ()
            end
            sb.Append(buildType(g, pageClass))
            first <- false
        done
        sb.Append ")"
        sb.Append "</div>"
    elif (t.IsGeneric) then
        if t.Category <> "Primitive" then
            sb.Append("<a class=\"type\" href=\""+baseURL+"/docs/api-reference/"+t.Category+"/"+t.CleanName+"\">")
        else
            sb.Append("<a class=\"type\" href=\""+baseURL+"/docs/api-reference/System/Primitives#"+t.CleanName.ToLower()+"\">")
        sb.Append(t.CleanName)
        sb.Append("</a>")
        sb.Append "<"
        let mutable first = true
        for g in t.Generics do
            if not (first) then begin
                sb.Append(", ")
                ()
            end
            sb.Append(buildType(g, pageClass))
            first <- false
        done
        sb.Append ">"
    elif (t.Category = "None") then
        sb.Append("<span class=\"type\">")
        sb.Append(t.CleanName)
        sb.Append("</span>")
    elif (t.Category = "Array") then
        sb.Append "<span>"
        sb.Append(buildType(t.Generics.[0], pageClass))
        sb.Append "[]"
        sb.Append "</span>"
    else
        if t.Name = pageClass.Name then
            sb.Append("<b class=\"page-type\">"+t.CleanName+"</b>")
        else (
            if t.Category <> "Primitive" then
                sb.Append("<a class=\"type\" href=\""+baseURL+"/docs/api-reference/"+t.Category+"/"+t.CleanName+"\">")
            else
                sb.Append("<a class=\"type\" href=\""+baseURL+"/docs/api-reference/System/Primitives#"+t.Name.ToLower()+"\">")
            sb.Append(t.CleanName)
            sb.Append("</a>")
        )
    sb.ToString()
end

let buildProperty(category: string, pageClass: ApiClass, prop: ApiProperty): string = begin
    let sb = new StringBuilder()
    let deprecatedClass = if pageClass.Tags.Contains "Deprecated" then "deprecated" else ""
    sb.AppendLine("<tr class=\"function-row "+deprecatedClass+"\">")
    sb.AppendLine "<td style=\"vertical-align:top;white-space:normal;\">"
    sb.AppendLine "<div>"
    sb.Append(buildType(prop.ValueType, pageClass))
    sb.Append "<span class=\"method-body\" style=\"text-indent: -2em; padding-left: 0.5em\">"
    sb.Append("<a class=\"name\" href=\"" + prop.Name + "\">")
    sb.Append prop.Name
    sb.Append "</a>"
    sb.Append "</span>"
    sb.AppendLine "</td>"
    sb.AppendLine "<td style=\"vertical-align:top;white-space:normal;\">"
    if prop.Comment.Summary <> null then begin
        sb.Append "<p>"
        sb.Append(FormatSummary(prop.Comment.Summary))
        sb.Append "</p>"
        ignore()
    end
    sb.AppendLine "</td>"
    sb.AppendLine "</tr>"
    sb.ToString()
end

let buildFunction(func: ApiFunction, pageClass: ApiClass): string = begin
    let sb = new StringBuilder()
    let deprecatedClass = if func.Tags.Contains "Deprecated" then "deprecated" else ""
    let genericClass = if func.IsGeneric then "generic" else ""
    sb.AppendLine("<tr class=\"function-row "+deprecatedClass+"\">")
    sb.AppendLine "<td style=\"vertical-align:top;white-space:normal;\">"
    sb.AppendLine "<div>"
    sb.Append(buildType(func.ReturnType, pageClass))
    sb.Append("<span class=\"method-body\" style=\"text-indent: -2em;\">")
    sb.Append("<a class=\"method-name "+ genericClass + " " + deprecatedClass + "\" href=\"" + func.Name + "\">")
    sb.Append func.Name
    sb.Append "</a>"
    sb.Append "</span>"
    if (func.IsGeneric) then begin
        sb.Append "<"
        for g in func.Generics do
            sb.Append "<span class=\"type\">"
            sb.Append(g)
            sb.Append "</span>"
        done
        sb.Append ">&nbsp;"
        ()
    end
    sb.Append "<span style=\"display: inline-block\">"
    sb.Append "("
    sb.Append " "
    sb.Append "<span class=\"param\" style=\"white-space: nowrap\">"

    let mutable isFirst = true
    for p in func.Parameters do
        if not (isFirst) then
            sb.Append ", " |> ignore
        sb.Append(buildType(p.Type, pageClass))
        sb.Append " "
        sb.Append p.Name

        if (p.Default <> null) then
            sb.Append " = " |> ignore
            sb.Append "<i>" |> ignore
            sb.Append p.Default |> ignore
            sb.Append "</i>" |> ignore

        isFirst <- false
    done

    sb.Append "</span> )</span>"
    sb.Append "</span>"
    sb.Append "</div>"
    sb.AppendLine "</td>"
    sb.AppendLine "<td style=\"vertical-align:top;white-space:normal;\">"
    if func.Comment.Summary <> null then begin
        sb.Append "<p>"
        sb.Append(FormatSummary(func.Comment.Summary))
        sb.Append "</p>"
        ignore()
    end
    sb.AppendLine "</td>"
    sb.AppendLine "</tr>"
    sb.ToString()
end


let buildEvent(func: ApiEvent, pageClass: ApiClass): string = begin
    let sb = new StringBuilder()
    let deprecatedClass = if func.Tags.Contains "Deprecated" then "deprecated" else ""
    sb.AppendLine("<tr class=\"function-row "+deprecatedClass+"\">")
    sb.AppendLine "<td style=\"vertical-align:top;white-space:normal;\">"
    sb.Append("<span class=\"event-body\" style=\"text-indent: -2em; padding-left: 0.5em\">")
    sb.Append("<a class=\"event-name " + deprecatedClass + "\" href=\"" + func.Name + "\">")
    sb.Append func.Name
    sb.Append "</a>"
    sb.Append "</span>"
    sb.Append "<span style=\"display: inline-block\">"
    sb.Append "&nbsp;("
    sb.Append " "
    sb.Append "<span class=\"param\" style=\"white-space: nowrap\">"

    let mutable isFirst = true
    for p in func.Parameters do
        if not (isFirst) then
            sb.Append ", " |> ignore
        sb.Append(buildType(p.Type, pageClass))
        sb.Append " "
        sb.Append p.Name
        isFirst <- false
    done

    sb.Append "</span> )</span>"
    sb.Append "</span>"
    sb.AppendLine "</td>"
    sb.AppendLine "<td style=\"vertical-align:top;white-space:normal;\">"
    if func.Comment.Summary <> null then begin
        sb.Append "<p>"
        sb.Append(FormatSummary(func.Comment.Summary))
        sb.Append "</p>"
        ignore()
    end
    sb.AppendLine "</td>"
    sb.AppendLine "</tr>"
    sb.ToString()
end

let buildIndexPage(category: string, desc: string, explorerImage: string, classes: ApiClass[], weight: int32): string = begin
    let sb = new StringBuilder()
    
    let date = sprintf "date: %s" (DateTime.UtcNow.ToString("yyyy-MM-dd"))
    let desc = sprintf "description: >\n\r  %s" desc
    let weight = sprintf "weight: %i" weight

    sb.AppendLine "---"
    sb.AppendLine("title: API:" + category)
    sb.AppendLine("linkTitle: " + category)
    sb.AppendLine weight
    sb.AppendLine("explorerImage: " + explorerImage)
    sb.AppendLine desc
    sb.AppendLine date
    sb.AppendLine "no_list: true"
    sb.AppendLine "toc_hide: true"
    sb.AppendLine "---"

    let groups = classes.GroupBy(fun i -> i.Name.[0]).OrderBy(fun i -> i.Key)
    
    sb.AppendLine "<div class=\"alphabetical-index\">"
    for group in groups do
        sb.AppendLine "<div class=\"idx-col\">"
        sb.Append "<h5>"
        sb.Append group.Key
        sb.AppendLine "</h5>"
        sb.AppendLine "<ul>"
        for c in group do
            let deprecated = if c.Tags.Contains "Deprecated" then "deprecated" else ""
            sb.AppendLine("<li class=\""+deprecated+"\">")
            sb.AppendLine("<img class=\"explorer-icon\" src=\""+baseURL+"/icons/silk/"+c.ExplorerImage+".png\">")
            sb.AppendLine("<a href=\""+baseURL+"/docs/api-reference/"+c.MemoryCategory+"/"+c.Name+"\">"+c.Name+"</a>")
            sb.AppendLine "</li>"
        done
        sb.AppendLine "</ul>"
        sb.AppendLine "</div>"
    done
    sb.AppendLine "</div>"

    sb.ToString()
end

let buildEnumIndexPage(category: string, desc: string, explorerImage: string, enums: ApiEnum[], weight: int32): string = begin
    let sb = new StringBuilder()
    
    let date = sprintf "date: %s" (DateTime.UtcNow.ToString("yyyy-MM-dd"))
    let desc = sprintf "description: >\n\r  %s" desc
    let weight = sprintf "weight: %i" weight

    sb.AppendLine "---"
    sb.AppendLine("title: API:" + category)
    sb.AppendLine("linkTitle: " + category)
    sb.AppendLine weight
    sb.AppendLine("explorerImage: " + explorerImage)
    sb.AppendLine desc
    sb.AppendLine date
    sb.AppendLine "no_list: true"
    sb.AppendLine "toc_hide: true"
    sb.AppendLine "---"

    let groups = enums.GroupBy(fun i -> i.Name.[0]).OrderBy(fun i -> i.Key)
    
    sb.AppendLine "<div class=\"alphabetical-index\">"
    for enum in groups do
        sb.AppendLine "<div class=\"idx-col\">"
        sb.Append "<h5>"
        sb.Append enum.Key
        sb.AppendLine "</h5>"
        sb.AppendLine "<ul>"
        for c in enum do
            sb.AppendLine "<li>"
            sb.AppendLine("<a href=\""+baseURL+"/docs/api-reference/Enum/"+c.Name+"\">"+c.Name+"</a>")
            sb.AppendLine "</li>"
        done
        sb.AppendLine "</ul>"
        sb.AppendLine "</div>"
    done
    sb.AppendLine "</div>"

    sb.ToString()
end


let buildEnumPage(e: ApiEnum, root: ApiRoot): string = begin

    let sb = new StringBuilder()
    
    let title = sprintf "title: API:Enum/%s" e.Name
    let linkTitle = sprintf "linkTitle: \"%s\"" e.Name
    let weight = sprintf "weight: %i" 4
    let date = sprintf "date: %s" (DateTime.UtcNow.ToString("yyyy-MM-dd"))
    let namesp = sprintf "namespace: Primrose.Enum.%s" e.Name

    sb.AppendLine "---"
    sb.AppendLine title
    sb.AppendLine linkTitle
    sb.AppendLine weight
    sb.AppendLine date
    sb.AppendLine namesp
    sb.AppendLine "no_list: true"
    sb.AppendLine "toc_hide: true"
    sb.AppendLine "---"

    if e.Comment.Summary <> null then begin
        sb.AppendLine "<p class=\"summary\">"
        sb.AppendLine(FormatSummary(e.Comment.Summary))
        sb.AppendLine "</p>"
        ignore()
    end
    if e.Comment.Remarks <> null then begin
        sb.AppendLine "### Notes"
        sb.Append "<p class=\"remarks\">"
        sb.Append(FormatSummary(e.Comment.Remarks))
        sb.Append "</p>"
        ignore()
    end

    sb.AppendLine " "
    sb.AppendLine "## Values"
    sb.AppendLine " "
    sb.AppendLine "<table class=\"studiohide\">"
    sb.AppendLine "<tbody>"
    for item in e.Items do

        sb.AppendLine "<tr class=\"enum-row\">"
        sb.AppendLine "<td style=\"vertical-align:top;white-space:normal;\">"
        sb.Append("<span class=\"name\"\">")
        sb.Append item.Name
        sb.Append "</span>"
        sb.AppendLine "</td>"
        sb.AppendLine "<td style=\"vertical-align:top;white-space:normal;\">"
        sb.Append("<b class=\"value\"\">")
        sb.Append(item.Value.ToString())
        sb.Append "</b>"
        sb.AppendLine "</td>"
        sb.AppendLine "<td style=\"vertical-align:top;white-space:normal;\">"
        if item.Comment.Summary <> null then begin
            sb.Append "<p>"
            sb.Append(FormatSummary(item.Comment.Summary))
            sb.Append "</p>"
            ignore()
        end
        sb.AppendLine "</td>"
        sb.AppendLine "</tr>"


    done
    sb.AppendLine "</tbody>"
    sb.AppendLine "</table>"
    
    sb.ToString()
end

let buildClassPage(c: ApiClass, root: ApiRoot): string = begin

    let sb = new StringBuilder()
    
    let title = sprintf "title: API:%s/%s" c.MemoryCategory c.Name
    let linkTitle = sprintf "linkTitle: \"%s\"" c.Name
    let weight = sprintf "weight: %i" 4
    let date = sprintf "date: %s" (DateTime.UtcNow.ToString("yyyy-MM-dd"))
    let explorerImage = sprintf "explorerImage: %s" c.ExplorerImage
    let namesp = sprintf "namespace: %s" c.FullName
    let deprecated = sprintf "deprecated: %b" (c.Tags.Contains "Deprecated")

    sb.AppendLine "---"
    sb.AppendLine title
    sb.AppendLine linkTitle
    sb.AppendLine weight
    sb.AppendLine date
    sb.AppendLine explorerImage
    sb.AppendLine namesp
    sb.AppendLine deprecated
    sb.AppendLine "no_list: true"
    sb.AppendLine "toc_hide: true"
    sb.AppendLine "---"

    sb.AppendLine(buildInheritance(c, root))

    if c.Comment.Summary <> null then begin
        sb.AppendLine "<p class=\"summary\">"
        sb.AppendLine(FormatSummary(c.Comment.Summary))
        sb.AppendLine "</p>"
        ignore()
    end
    if c.Comment.Remarks <> null then begin
        sb.AppendLine "### Notes"
        sb.Append "<p class=\"remarks\">"
        sb.Append(FormatSummary(c.Comment.Remarks))
        sb.Append "</p>"
        ignore()
    end

    sb.AppendLine " "
    sb.AppendLine "## Properties"
    sb.AppendLine " "
    sb.AppendLine "<table class=\"studiohide\">"
    sb.AppendLine "<tbody>"
    for p in c.Members.OfType<ApiProperty>().OrderBy(fun p -> p.Name) do
        sb.AppendLine(buildProperty("Class", c, p))
    done
    sb.AppendLine "</tbody>"
    sb.AppendLine "</table>"
    
    sb.AppendLine " "
    sb.AppendLine "## Functions"
    sb.AppendLine " "
    sb.AppendLine "<table class=\"studiohide\">"
    sb.AppendLine "<tbody>"
    for f in c.Members.OfType<ApiFunction>().OrderBy(fun p -> p.Name) do
        sb.AppendLine(buildFunction(f, c))
    done
    sb.AppendLine "</tbody>"
    sb.AppendLine "</table>"

    sb.AppendLine " "
    sb.AppendLine "## Events"
    sb.AppendLine " "
    sb.AppendLine "<table class=\"studiohide\">"
    sb.AppendLine "<tbody>"
    for f in c.Members.OfType<ApiEvent>().OrderBy(fun p -> p.Name) do
        sb.AppendLine(buildEvent(f, c))
        ()
    done
    sb.AppendLine "</tbody>"
    sb.AppendLine "</table>"

    sb.AppendLine "<b>"    
    let pos = sb.Length;
    sb.AppendLine "</b>"

    let mutable hasInheritors = false

    let rec appendInheritors(start: ApiClass) = begin
        sb.AppendLine("<ul class=\""+(if start = c then "root" else "nested")+"\">")
        for inheritor in root.Classes.Where(fun oc -> oc.Superclass = start.FullName) do
            hasInheritors <- true
            let className = if inheritor.Tags.Contains "Deprecated" then "deprecated" else ""
            sb.Append("<a class=\""+className+"\" href=\""+baseURL+"/docs/api-reference/Class/"+inheritor.Name+"\">")
            sb.Append("<img src=\""+baseURL+"/icons/silk/"+inheritor.ExplorerImage+".png\"/>")
            sb.Append "&nbsp;"
            sb.Append(inheritor.Name)
            sb.AppendLine("</a>")
            appendInheritors(inheritor)
        done
        sb.AppendLine "</ul>"
        ()
    end
    
    sb.AppendLine "<div class=\"inheritors\">"
    appendInheritors(c)
    if (hasInheritors) then
        sb.Insert(pos, "Inherited by:") |> ignore
    sb.AppendLine "</div>"
    
    sb.ToString()
end

let buildFunctionPage(m: ApiFunction, pageClass: ApiClass, root: ApiRoot): string = begin

    let sb = new StringBuilder()

    if (m.Name.Contains "WaitForChild") then
        ignore();

    let title = sprintf "title: API:%s/%s/%s" pageClass.MemoryCategory pageClass.Name m.Name
    let linkTitle = sprintf "linkTitle: \"%s\"" m.Name
    let weight = sprintf "weight: %i" ((int)m.Name.[0])
    let date = sprintf "date: %s" (DateTime.UtcNow.ToString("yyyy-MM-dd"))
    let namesp = sprintf "namespace: %s.%s" pageClass.FullName m.Name
    let deprecated = sprintf "deprecated: %b" (m.Tags.Contains "Deprecated")

    sb.AppendLine "---"
    sb.AppendLine title
    sb.AppendLine linkTitle
    sb.AppendLine weight
    sb.AppendLine date
    sb.AppendLine namesp
    sb.AppendLine deprecated
    sb.AppendLine "no_list: true"
    sb.AppendLine "toc_hide: true"
    sb.AppendLine "---"

    sb.Append "Method of "
    sb.Append("<a href=\""+baseURL+"/docs/api-reference/Class/"+pageClass.Name+"\">")
    sb.Append("<img src=\""+baseURL+"/icons/silk/"+pageClass.ExplorerImage+".png\"/>")
    sb.Append "&nbsp;"
    sb.Append(pageClass.Name)
    sb.AppendLine("</a>")

    sb.AppendLine "<pre class=\"method-declaration\">"
    sb.Append m.Name 
    if m.Parameters.Length = 0 then
        sb.Append("(): ") 
    else
        sb.AppendLine(" (")
        let mutable first = true
        for param in m.Parameters do
            if not (first) then
                sb.Append ","
                sb.AppendLine() |> ignore
            sb.Append "    "
            sb.Append param.Name
            sb.Append ": "
            sb.Append(buildType(param.Type, pageClass))

            if param.Default <> null then
                if param.Type.Name = "String" then
                    sb.Append " = <a class=\"default-param string-param\">"
                else
                    sb.Append " = <a class=\"default-param int-param\">"
                sb.Append(param.Default)
                sb.Append "</a>" |> ignore

            first <- false
        done
        sb.AppendLine()
        sb.Append("): ")
    sb.Append(buildType(m.ReturnType, pageClass))
    sb.AppendLine("</pre>")

    sb.AppendLine "<b>Return Type: </b>"
    sb.AppendLine(buildType(m.ReturnType, pageClass))
    sb.AppendLine("<br/>")
    
    sb.Append "<b>Description: </b>"
    if m.Comment.Summary <> null then begin
        sb.AppendLine(FormatSummary(m.Comment.Summary))
        ignore()
    end
    if m.Comment.Remarks <> null then begin
        sb.AppendLine "<b>Notes: </b>"
        sb.Append "<p class=\"remarks\">"
        sb.Append(FormatSummary(m.Comment.Remarks))
        sb.Append "</p>"
        ignore()
    end
    
    sb.ToString()
end

let callback = fun((x: int, y: int, z: int)) -> begin
    ()
end

let event = Primrose.DataModel.Networking.RemoteEvent()
event.ServerFired.connect(callback)

let buildPropertyPage(p: ApiProperty, c: ApiClass, root: ApiRoot): string = begin

    let sb = new StringBuilder()

    let title = sprintf "title: API:%s/%s/%s" c.MemoryCategory c.Name p.Name
    let linkTitle = sprintf "linkTitle: \"%s\"" p.Name
    let weight = sprintf "weight: %i" ((int)p.Name.[0])
    let date = sprintf "date: %s" (DateTime.UtcNow.ToString("yyyy-MM-dd"))
    let namesp = sprintf "namespace: %s.%s" c.FullName p.Name
    let deprecated = sprintf "deprecated: %b" (p.Tags.Contains "Deprecated")

    sb.AppendLine "---"
    sb.AppendLine title
    sb.AppendLine linkTitle
    sb.AppendLine weight
    sb.AppendLine date
    sb.AppendLine namesp
    sb.AppendLine deprecated
    sb.AppendLine "no_list: true"
    sb.AppendLine "toc_hide: true"
    sb.AppendLine "---"

    sb.Append "Property of "
    sb.Append("<a href=\""+baseURL+"/docs/api-reference/Class/"+c.Name+"\">")
    sb.Append("<img src=\""+baseURL+"/icons/silk/"+c.ExplorerImage+".png\"/>")
    sb.Append "&nbsp;"
    sb.Append(c.Name)
    sb.AppendLine("</a>")

    sb.AppendLine "<pre class=\"method-declaration\">"
    sb.Append p.Name 
    sb.Append ": "
    sb.Append(buildType(p.ValueType, c))
    sb.AppendLine("</pre>")

    sb.AppendLine "<b>Value Type: </b>"
    sb.AppendLine(buildType(p.ValueType, c))
    sb.AppendLine("<br/>")
    
    sb.Append "<b>Description: </b>"
    if p.Comment.Summary <> null then begin
        sb.AppendLine(FormatSummary(p.Comment.Summary))
        ignore()
    end
    if p.Comment.Remarks <> null then begin
        sb.AppendLine "<b>Notes: </b>"
        sb.Append "<p class=\"remarks\">"
        sb.Append(FormatSummary(p.Comment.Remarks))
        sb.AppendLine "</p>"
        ignore()
    end
    
    sb.ToString()
end

let generateWebsite(root: ApiRoot) = begin
    let classDir = Path.Combine(docsDir, "Class")
    let assetsDir = Path.Combine(docsDir, "Asset")
    let enumDir = Path.Combine(docsDir, "Enum")

    if (Directory.Exists(classDir)) then begin
        for f in Directory.GetDirectories(classDir) do Directory.Delete(f, true)
    end
    if (Directory.Exists(assetsDir)) then begin
        for f in Directory.GetDirectories(assetsDir) do Directory.Delete(f, true)
    end
    if (Directory.Exists(enumDir)) then begin
        for f in Directory.GetDirectories(enumDir) do Directory.Delete(f, true)
    end

    for c in root.Classes.Where(fun c -> not(c.Tags.Contains("NotBrowsable"))) do
        let page = buildClassPage(c, root)
        Directory.CreateDirectory(Path.Combine(classDir, c.Name))
        File.WriteAllText(Path.Combine(classDir, c.Name, "_index.md"), page)
        for m in c.Members.OfType<ApiFunction>() do
            let page = buildFunctionPage(m, c, root)
            File.WriteAllText(Path.Combine(classDir, c.Name, m.Name+".md"), page)
        done
        for p in c.Members.OfType<ApiProperty>() do
            let page = buildPropertyPage(p, c, root)
            File.WriteAllText(Path.Combine(classDir, c.Name, p.Name+".md"), page)
        done
    done
    File.WriteAllText(Path.Combine(classDir, "_index.md"), buildIndexPage("Class", "A list of classes in the engine.", "class", root.Classes, 2))

    for a in root.Assets do
        let page = buildClassPage(a, root)
        Directory.CreateDirectory(Path.Combine(assetsDir, a.Name))
        File.WriteAllText(Path.Combine(assetsDir, a.Name, "_index.md"), page)
        for m in a.Members.OfType<ApiFunction>() do
            let page = buildFunctionPage(m, a, root)
            File.WriteAllText(Path.Combine(assetsDir, a.Name, m.Name+".md"), page)
        done
        for p in a.Members.OfType<ApiProperty>() do
            let page = buildPropertyPage(p, a, root)
            File.WriteAllText(Path.Combine(assetsDir, a.Name, p.Name+".md"), page)
        done
    done
    File.WriteAllText(Path.Combine(assetsDir, "_index.md"), buildIndexPage("Asset", "A list of asset types in the engine.", "package", root.Assets, 6))
    
    for c in root.Enums do
        let page = buildEnumPage(c, root)
        File.WriteAllText(Path.Combine(enumDir, c.Name + ".md"), page)
    done
    File.WriteAllText(Path.Combine(enumDir, "_index.md"), buildEnumIndexPage("Enum", "A list of enums in the engine.", "", root.Enums, 7))

end

let apiRoot = DumpAPI()

generateWebsite(apiRoot)

let result = JsonConvert.SerializeObject(apiRoot, Formatting.Indented)
File.WriteAllText("API-Dump.json", result) 
