namespace ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Truenary_Solution_Problem
{
    public abstract class AddSpecificStudent : ITruenarySolution
    {
        private ITruenarySolution _truenarySolution;

        protected AddSpecificStudent(ITruenarySolution truenarySolution)
        {
            this._truenarySolution = truenarySolution;
        }

        public virtual void webDevelopmentIntern()
        {
            _truenarySolution.webDevelopmentIntern();
            
        }
    }
}