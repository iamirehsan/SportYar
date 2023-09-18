namespace SportYar.Infrastructure.StaticMethods
{
    public static class CodeGenerator
    {
        public static string RandomCode(int codeLength, Random random)
        {
            var code = string.Empty;
            while (code.Length < codeLength)
            {
                code += random.Next(0, 9).ToString();

            }
            return code;

        }

    }
}
