namespace Asyncs
{
    internal class Class1
    {
        private string _text = string.Empty;
        private string _result = string.Empty;

        private readonly string path = @"someText.txt";
        private readonly string path1 = @"someText1.txt";

        public async Task<string> HelloAsync()
        {
            await Task.Run(() =>
            {
                using (var sr = new StreamReader(path))
                {
                    _text = sr.ReadToEnd();
                }
            });
            return _text;
        }

        public async Task<string> WordAsync()
        {
            await Task.Run(() =>
            {
                using (var sr = new StreamReader(path1))
                {
                    _text = sr.ReadToEnd();
                }
            });
            return _text;
        }

        public async Task<string> ConctAsync()
        {
            await Task.Run(async () =>
              {
                  var a = await HelloAsync();
                  var b = await WordAsync();
                  _result = $"{a} {b}";

                  Console.WriteLine(_result);
              });
            return _result;
        }
    }
}
