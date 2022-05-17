using System.IO;

using Eighty.CodeGen;

File.WriteAllText("Eighty/Html.Tags.Generated.cs", new HtmlTagsGenerator().GenerateTags());
File.WriteAllText("Eighty/Html._.Generated.cs", new HtmlUnderscoreGenerator().GenerateUnderscores());
File.WriteAllText("Eighty/Html.TagFactory.Generated.cs", new HtmlTagFactoryGenerator().GenerateTagFactoryMethods());
File.WriteAllText("Eighty/TagBuilder._.Generated.cs", new TagBuilderGenerator().GenerateTagBuilderMethods());
File.WriteAllText("Eighty/Twenty/HtmlBuilder.Tags.Generated.cs", new HtmlBuilderTagsGenerator().GenerateFile());
File.WriteAllText("Eighty/Twenty/HtmlBuilder.TagFactory.Generated.cs", new HtmlBuilderTagFactoryGenerator().GenerateTagFactoryMethods());
