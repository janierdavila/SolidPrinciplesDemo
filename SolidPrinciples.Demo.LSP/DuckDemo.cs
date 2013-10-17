namespace SolidPrinciples.Demo.LSP
{
    public class DuckDemo
    {
        public void MakeDuckSwim(IDuck duck)
        {
            duck.Swim();
        }
    }


    public interface IDuck
    {
        void Swim();
        // contract says that IsSwimming should be true of Swim has been called.
        bool IsSwimming { get; }
    }


    public class OrganicDuck : IDuck
    {
        public void Swim()
        {
            //do something to swim
        }

        public bool IsSwimming { get { return true; /* return if the duck is swimming */ } }
    }


    public class ElectricDuck : IDuck
    {
        bool _isSwimming;

        public void Swim()
        {
            if (!IsTurnedOn)
                return;

            _isSwimming = true;
            //swim logic  

        }

        public bool IsTurnedOn { get; set; }

        public bool IsSwimming { get { return _isSwimming; } }

    }
}
