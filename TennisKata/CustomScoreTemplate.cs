using JetBrains.Annotations;

namespace CustomSourceTemplate
{
    public static class JoeySourceTemplates
    {
        [JetBrains.Annotations.SourceTemplateAttribute]
        [Macro(Target = "expected", Editable = 1)]
        public static void ae<T>(this T source)
        {
            /*$ Assert.AreEqual( $expected$ , source);*/
        }

        [JetBrains.Annotations.SourceTemplateAttribute]
        public static void abs<T>(this T source)
        {
            /*$ Math.Abs(source)*/
        }
    }
}