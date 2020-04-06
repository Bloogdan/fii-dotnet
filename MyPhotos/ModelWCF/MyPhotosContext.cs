namespace ModelWCF
{
    public class MyPhotosContext
    {
        private static ModelContainer Context;
        private MyPhotosContext() { }

        public static ModelContainer GetContext()
        {
            if (Context == null)
            {
                Context = new ModelContainer();
            }
            return Context;
        }

    }
}