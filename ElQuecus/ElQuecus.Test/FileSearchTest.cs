using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElQuecus.Test
{
    [TestClass]
    public class FileSearchTest
    {
        [TestMethod]
        public void GetFilePaths_return_correct_paths()
        {
            List<string> _checkList = new List<string>()
            {
                @"C:\Users\DarkS\Source\Repos\ElQuecus\ElQuecus\ElQuecus.Test\Hollywood Undead- Does Everybody In the World Have To Die.mp3",
                @"C:\Users\DarkS\Source\Repos\ElQuecus\ElQuecus\ElQuecus.Test\Hollywood Undead - Disease.mp3",
                @"C:\Users\DarkS\Source\Repos\ElQuecus\ElQuecus\ElQuecus.Test\Hollywood Undead- Party By Myself.mp3"
            };
            var checkedPath = @"C:\Users\DarkS\Source\Repos\ElQuecus\ElQuecus\ElQuecus.Test";
            var test = FileSearch.GetFilePaths(checkedPath).Result;
            Assert.AreEqual(_checkList.Except(test).Count(), 0);
        }
        [TestMethod]
        public async Task GetFilePaths_return_nothing()
        {
            var data =
                await FileSearch.GetFilePaths(@"C:\Users\DarkS\Source\Repos\ElQuecus\ElQuecus\ElQuecus.Test\Properties");
            Assert.AreEqual(data.Count, 0);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public async Task GetFilePaths_throw_argument_exception()
        {
            await FileSearch.GetFilePaths("lol");
        }

        


}
}
