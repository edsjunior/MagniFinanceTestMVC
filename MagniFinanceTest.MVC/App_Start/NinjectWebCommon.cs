using MagniFinanceTest.Application;
using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using MagniFinanceTest.Domain.Interfaces.Services;
using MagniFinanceTest.Domain.Services;
using MagniFinanceTest.Infrastructure.Data.Repositories;


[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MagniFinanceTest.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(MagniFinanceTest.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace MagniFinanceTest.MVC.App_Start
{
	using System;
	using System.Web;

	using Microsoft.Web.Infrastructure.DynamicModuleHelper;

	using Ninject;
	using Ninject.Web.Common;
	using Ninject.Web.Common.WebHost;

	public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<ICourseAppService>().To<CourseAppService>();
            kernel.Bind<ICourseSubjectsAppService>().To<CourseSubjectsAppService>();
            kernel.Bind<IStudentAppService>().To<StudentAppService>();
            kernel.Bind<IStudentSubjectsAppService>().To<StudentsSubjectsAppService>();
            kernel.Bind<ITeacherAppService>().To<TeacherAppService>();
            kernel.Bind<IGradeAppService>().To<GradeAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<ICourseService>().To<CourseService>();
            kernel.Bind<ICourseSubjectsService>().To<CourseSubjectsService>();
            kernel.Bind<IStudentService>().To<StudentService>();
            kernel.Bind<IStudentSubjectsService>().To<StudentSubjectsService>();
            kernel.Bind<ITeacherService>().To<TeacherService>();
            kernel.Bind<IGradeService>().To<GradeService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<ICourseRepository>().To<CourseRepository>();
            kernel.Bind<ICourseSubjectsRepository>().To<CourseSubjectsRepository>();
            kernel.Bind<IStudentRepository>().To<StudentRepository>();
            kernel.Bind<IStudentSubjectsRepository>().To<StudentSubjectsRepository>();
            kernel.Bind<ITeacherRepository>().To<TeacherRepository>();
            kernel.Bind<IGradeRepository>().To<GradeRepository>();
        }
    }
}