using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicCollectionApp;

namespace MusicCollectionAppTests
{
    [TestClass]
    public class MusicTrackTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void YearLessThan1900_IsNotAllowed()
        {
            new MusicTrack("Artist", "Title", "Genre", 1899);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void YearGreaterThanCurrent_IsNotAllowed()
        {
            new MusicTrack("Artist", "Title", "Genre", DateTime.Now.Year + 1);
        }

        [TestMethod]
        public void Year1900_IsAllowed()
        {
            int year = 1900;

            var track = new MusicTrack("Artist", "Title", "Genre", year);

            Assert.AreEqual(year, track.Year);
        }

        [TestMethod]
        public void YearCurrent_IsAllowed()
        {
            int year = DateTime.Now.Year;

            var track = new MusicTrack("Artist", "Title", "Genre", year);

            Assert.AreEqual(year, track.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyArtist_IsNotAllowed()
        {
            new MusicTrack("", "Title", "Genre", 2020);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhitespaceArtist_IsNotAllowed()
        {
            new MusicTrack("   ", "Title", "Genre", 2020);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyTitle_IsNotAllowed()
        {
            new MusicTrack("Artist", "", "Genre", 2020);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhitespaceTitle_IsNotAllowed()
        {
            new MusicTrack("Artist", "   ", "Genre", 2020);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeYear_IsNotAllowed()
        {
            new MusicTrack("Artist", "Title", "Genre", -100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void YearZero_IsNotAllowed()
        {
            new MusicTrack("Artist", "Title", "Genre", 0);
        }

        [TestMethod]
        public void Constructor_ValidData_CreatesTrack()
        {
            string artist = "Artist";
            string title = "Title";
            string genre = "Genre";
            int year = 2020;

            var track = new MusicTrack(artist, title, genre, year);

            Assert.AreEqual(artist, track.Artist);
            Assert.AreEqual(title, track.Title);
            Assert.AreEqual(genre, track.Genre);
            Assert.AreEqual(year, track.Year);
        }
    }
}
