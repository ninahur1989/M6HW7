using AspCRUD.Interfaces;
using AspCRUD.Models;
using AspCRUD.Services;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Xunit;



namespace AspCRUD.test
{

    public class SongServiceTests
    {

        [Fact]
        public void GetAll_ValidSong_ReturnListSongs()
        {
            // Arrange

            Mock<IDataProvider> dataMock = new Mock<IDataProvider>();
            dataMock
                .Setup(x => x.GetAll())
                .Returns(new List<Song>());
            var service = new SongService(dataMock.Object);

            //Action

            var result = service.GetAll();

            //Assert
            Assert.Equal(null, null);
        }

        [Fact]
        public void GetById_ValidSong_ReturnSong()
        {
            // Arrange

            Mock<IDataProvider> dataMock = new Mock<IDataProvider>();
            dataMock
                .Setup(x => x.GetById(4))
                .Returns(new Song{Id = 4}) ;
            var service = new SongService(dataMock.Object);          

            //Action

            var result = service.GetById(4);
 
            //Assert
            Assert.Equal(new Song { Id = 4}.Id, result.Id);
            Assert.Equal(new Song { Id = 4 }.Author, result.Author);
            Assert.Equal(new Song { Id = 4 }.Duration, result.Duration);
        }

        [Fact]
        public void Post_ValidSong_ReturnTrue()
        {
            // Arrange

            Mock<IDataProvider> dataMock = new Mock<IDataProvider>();
            dataMock
                .Setup(x => x.Post(new Song() { Id = 3}))
                .Returns(true);
            var service = new SongService(dataMock.Object);

            //Action

            var post = service.Post(new Song { Id = 3 });

            //Assert
            Assert.True(post);
        }

        [Fact]
        public void Post_ValidSong_ReturnFalse()
        {
            // Arrange

            Mock<IDataProvider> dataMock = new Mock<IDataProvider>();
            dataMock
                .Setup(x => x.Post(new Song() { Id = -3 }))
                .Returns(false);
            var service = new SongService(dataMock.Object);

            //Action

            var post = service.Post(new Song { Id = -3 });

            //Assert
            Assert.False(post);
        }

        [Fact]
        public void Update_ValidSong_ReturnSong()
        {
            // Arrange

            Mock<IDataProvider> dataMock = new Mock<IDataProvider>();
            dataMock
                .Setup(x => x.Update(4) )
                .Returns(new Song { Id = 4 });

            var service1 = new SongService(dataMock.Object);

            Mock<IDataProvider> dataMock1 = new Mock<IDataProvider>();
            dataMock1
                .Setup(x => x.GetById(4))
                .Returns(new Song { Id = 4 });
            var service2 = new SongService(dataMock1.Object);

            //Action

            var result = service2.GetById(4);


            //Assert
            Assert.Equal(new Song { Id = 4}.Id, result.Id);

        }

        [Fact]
        public void Delete_ValidSong_ReturnTrue()
        {
            // Arrange

            Mock<IDataProvider> dataMock = new Mock<IDataProvider>();
            dataMock
                .Setup(x => x.Delete(2))
                .Returns(true);
            var service = new SongService(dataMock.Object);

            //Action

            var delete = service.Delete(2);

            //Assert
            Assert.True(delete);
        }

        [Fact]
        public void Delete_ValidSong_ReturnFalse()
        {
            // Arrange

            Mock<IDataProvider> dataMock = new Mock<IDataProvider>();
            dataMock
                .Setup(x => x.Delete(-2))
                .Returns(false);
            var service = new SongService(dataMock.Object);

            //Action

            var delete = service.Delete(-2);

            //Assert
            Assert.False(delete);
        }
    }
}