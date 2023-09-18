using BusinessLayer.Dtos.About;
using BusinessLayer.Dtos.Contact;
using BusinessLayer.Dtos.ContactForm;
using BusinessLayer.Dtos.Nav;
using BusinessLayer.Dtos.OnlineSell;
using BusinessLayer.Dtos.Product;
using BusinessLayer.Dtos.ProductCategory;
using BusinessLayer.Dtos.ProductImage;
using BusinessLayer.Dtos.Slide;
using BusinessLayer.Dtos.Social;
using DataLayer.Entities;

namespace BusinessLayer.Profile;

public class ProfileMap:AutoMapper.Profile
{
    public ProfileMap()
    {
        //About
        CreateMap<AboutDto, About>().ReverseMap();    
        CreateMap<UpdateAboutDto, About>().ReverseMap();

        //Contact
        CreateMap<ContactDto, Contact>().ReverseMap();
        CreateMap<UpdateContactDto, Contact>().ReverseMap();

        //ContactForm
        CreateMap<ContactFormDto, ContactForm>().ReverseMap();
        CreateMap<UpdateContactFormDto, ContactForm>().ReverseMap();

        //Nav
        CreateMap<NavDto, Nav>().ReverseMap();
        CreateMap<UpdateNavDto, Nav>().ReverseMap();

        //OnlineSell
        CreateMap<OnlineSellDto, OnlineSell>().ReverseMap();
        CreateMap<UpdateOnlineSellDto, OnlineSell>().ReverseMap();

        //Product
        CreateMap<ProductDto, Product>().ReverseMap();
        CreateMap<UpdateProductDto, Product>().ReverseMap();

        //ProductCategory
        CreateMap<ProductCategoryDto, ProductCategory>().ReverseMap();
        CreateMap<UpdateProductCategoryDto, ProductCategory>().ReverseMap();

        //ProductImage
        CreateMap<ProductImageDto, ProductImage>().ReverseMap();
        CreateMap<UpdateProductImageDto, ProductImage>().ReverseMap();

        //Slide
        CreateMap<SlideDto, Slide>().ReverseMap();
        CreateMap<UpdateSlideDto, Slide>().ReverseMap();

        //Social
        CreateMap<SocialDto, Social>().ReverseMap();
        CreateMap<UpdateSocialDto, Social>().ReverseMap();
    }
}
