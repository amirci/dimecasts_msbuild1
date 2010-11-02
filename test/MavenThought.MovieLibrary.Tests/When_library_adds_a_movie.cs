using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;
using MbUnit.Framework;
using SharpTestsEx;

namespace MavenThought.MovieLibrary.Tests
{
    /// <summary>
    /// Specification when adding movies to the library
    /// </summary>
    [Specification]
    public class When_library_adds_a_movie : LibrarySpecification
    {
        /// <summary>
        /// Expected movie to be found in the library
        /// </summary>
        private IMovie _expected;

        /// <summary>
        /// Checks that the movie is found in the library
        /// </summary>
        [Test]
        public void Should_find_the_movie_in_the_library()
        {
            this.Sut.Contents
                .Should()
                .Have
                .SameValuesAs(Enumerable.Create(this._expected));
        }

        /// <summary>
        /// Setup the expected movie
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            _expected = Mock<IMovie>();
        }

        /// <summary>
        /// Add the movie to the library
        /// </summary>
        protected override void WhenIRun()
        {
            this.Sut.Add(this._expected);
        }
    }
}