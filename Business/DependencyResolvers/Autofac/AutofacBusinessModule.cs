using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    //Interface lerin karşılık bulduğu yer tam olarak burasıdır.
    public class AutofacBusinessModule : Module //Autofac ile birlikte gelen bir sınıf olan Module kullandık.
    {
        //Konfigurasyonlar burada yapılacak. Load'ın içerisinde.
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();//Bir constructorda IProductService gibi bir şey istenirse ProductManager verilecek.
            builder.RegisterType<EfProductDal>().As<IProductDal>();//Bir constructorda IProductDal gibi bir şey istenirse EfProductDal verilecek.

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly(); //Mevcut assembly e ulaş

            //Tanımladığımız assembly değişkenindeki bütün tipleri kayıt et,
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
