using ElQuecus.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElQuecus.Test
{
    [TestClass]
    public class PathToSongListConverterTest
    {
        [TestMethod]
        public void GetFileReturnCorrectSongList()
        {
            var testSong = new Song(
                "Hollywood Undead", " Disease", "3:32", "C:\\Users\\DarkS\\Source\\Repos\\ElQuecus\\ElQuecus\\ElQuecus.Test\\TestMusic\\Hollywood Undead - Disease.mp3"
                );
            var checkSong =
                PathToSongListConverter.GetFile(
                    @"C:\Users\DarkS\Source\Repos\ElQuecus\ElQuecus\ElQuecus.Test\TestMusic\Hollywood Undead - Disease.mp3");
           Assert.IsTrue(testSong.Equals(checkSong));
        }
    }
}