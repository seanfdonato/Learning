namespace OOP
{
    /** 
     * 
     */
    class Private
    {
        public Private()
        {

        }
        // Only accesseble insed the class
        private void MethodPrivate()
        {

        }
        public void MethodPublic()
        {
            MethodPrivate();
        }
        //Accessible only for derived classes
        protected void MethodProtected()
        {

        }
        // Accessible inherited or the same assembly
        protected internal void MethodProtectedInternal()
        {

        }
        //Accessible only inherited and a own class
        protected private void MethodProtectedPrivate()
        {

        }

    }
    //Just accessible for the assembly, Unless that use a notation;
    internal class Internal
    {
        private readonly Private _private;
        private readonly Public _public;
        public Internal()
        {
            _private = new Private();
            _public = new Public();
        }
        //Accessible only insed this class
        private void MethodPrivate()
        {

        }
        public void MethodPublic()
        {
            MethodPrivate();
            _private.MethodPublic();
            _public.MethodPublic();
            _public.MethodProtectedInternal();
        }
        //Accessible only for derived classes
        protected void MethodProtected()
        {

        }
        // Accessible inherited or the same assembly
        protected internal void MethodProtectedInternal()
        {

        }
        //Accessible only inherited and a own class
        protected private void MethodProtectedPrivate()
        {

        }

    }
    // For all
    public class Public
    {
        private readonly Private _private;
        private readonly Internal _internal;
        public Public()
        {
            _private = new Private();

            _private.MethodPublic();

            _internal = new Internal();

            _internal.MethodPublic();

        }
        private void MethodPrivate()
        {

        }
        public void MethodPublic()
        {
            MethodPrivate();
        }
        //Accessible only for derived classes
        protected void MethodProtected()
        {

        }
        // Accessible inherited or the same assembly
        protected internal void MethodProtectedInternal()
        {

        }
        //Accessible only inherited and a own class
        protected private void MethodProtectedPrivate()
        {

        }

    }

    public class ProtectedInherit : Public
    {
        public ProtectedInherit()
        {
            MethodProtectedInternal();

            MethodProtectedPrivate();
        }
    }
}