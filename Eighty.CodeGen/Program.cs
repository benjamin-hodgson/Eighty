using System.IO;

using Eighty.CodeGen;

File.WriteAllText("Eighty/Html.Tags.Generated.cs", HtmlTagsGenerator.GenerateTags());
File.WriteAllText("Eighty/Html._.Generated.cs", HtmlUnderscoreGenerator.GenerateUnderscores());
File.WriteAllText("Eighty/Html.TagFactory.Generated.cs", HtmlTagFactoryGenerator.GenerateTagFactoryMethods());
File.WriteAllText("Eighty/TagBuilder._.Generated.cs", TagBuilderGenerator.GenerateTagBuilderMethods());
File.WriteAllText("Eighty/Twenty/HtmlBuilder.Tags.Generated.cs", HtmlBuilderTagsGenerator.GenerateFile());
File.WriteAllText("Eighty/Twenty/HtmlBuilder.TagFactory.Generated.cs", HtmlBuilderTagFactoryGenerator.GenerateTagFactoryMethods());
