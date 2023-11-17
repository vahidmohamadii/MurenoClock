using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Entities;
using Moq;
using Shouldly;

namespace MuronoClockTest;

public class UnitTest1
{

    private Mock<IAboutRepository> _aboutRepository;
    About _about;

    public UnitTest1()
    {
        _aboutRepository = MockRepository.GetAlAboutRepository();
        _about = new About() { Id = 1, Title = "t", Description = "dd" };
    }
    [Fact]
    public async void Test1()
    {
       var res =await _aboutRepository.Object.GetAllAsync();

        res.ShouldBeOfType<List<About>>();
        res.Count.ShouldBe(2);
    }
    [Fact]
    public async void Test2()
    {
        var res = await _aboutRepository.Object.InsertAsync(_about, CancellationToken.None,true);

        res.ShouldBeOfType<About>();
        var allabouts=await _aboutRepository.Object.GetAllAsync();

        allabouts.Count.ShouldBe(3);

    }
}