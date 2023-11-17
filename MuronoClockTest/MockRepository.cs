

using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Entities;
using Moq;

namespace MuronoClockTest;

public class MockRepository
{
    public static Mock<IAboutRepository> GetAlAboutRepository()
    {
        var abouts = new List<About> { new About() { Id=1, Title="test",Description="destest"},
       new About() { Id=2, Title="test2",Description="destest2"}, };

        var mockrepo= new Mock<IAboutRepository>();
        mockrepo.Setup(x => x.GetAllAsync(null, null, "")).ReturnsAsync(abouts);

        //mockrepo.Setup(x => x.InsertAsync(It.IsAny<About>(),CancellationToken.None,true)).ReturnsAsync((About abou)=>

        //{
        //    abouts.Add(abou);
        //    return abou;
        //}
        //);
        

        return mockrepo;


    }
    public static Mock<IAboutRepository> InsertAboutRepository()
    {
        var abouts = new List<About> { new About() { Id=1, Title="test",Description="destest"},
       new About() { Id=2, Title="test2",Description="destest2"}, };

        var mockrepo = new Mock<IAboutRepository>();

        mockrepo.Setup(x => x.InsertAsync(It.IsAny<About>(), CancellationToken.None, true)).ReturnsAsync((About abou) =>

        {
            abouts.Add(abou);
            return abou;
        }
        );


        return mockrepo;


    }
}
