namespace LazyCapybara_v2
{
    using AutoMapper;
    using LazyCapybara_v2.Security.Profiles;

    public static class Program
    {
        private static IMapper mapper;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new MapperConfiguration(config =>
            {
                config.AddProfiles(new List<Profile>
                {
                    new RoomProfile(),
                    new TenantProfile()
                });
            });

            mapper = config.CreateMapper();
            ApplicationConfiguration.Initialize();
            Application.Run(new Lazy_CapybaraForm());
        }

        public static IMapper GetYourMapper()
        {
            return mapper;
        }

    }
}