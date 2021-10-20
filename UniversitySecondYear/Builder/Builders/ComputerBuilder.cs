using ArchotekturaLabTwo.Models;

namespace ArchotekturaLabTwo.Builders {
    public abstract class ComputerBuilder {
        public Computer Computer { get; set; }
        public abstract void BuildMotherboard();
        public abstract void BuildProcessor();
        public abstract void BuildDrive();
        public abstract void BuildScreen();

    }
}