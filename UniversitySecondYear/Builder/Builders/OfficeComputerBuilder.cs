using ArchotekturaLabTwo.Models;

namespace ArchotekturaLabTwo.Builders {
    public class OfficeComputerBuilder : ComputerBuilder {
        public OfficeComputerBuilder() {
            Computer = new Computer("biurowy");
        }

        public override void BuildMotherboard() {
            Computer.MotherBoard = "Asus Prime A320M-E";
            Computer.Price += 259.90;
        }

        public override void BuildProcessor() {
            Computer.Processor = "AMD Ryzen 5 2600";
            Computer.Price += 589.00;
        }

        public override void BuildDrive() {
            Computer.Drive = "Goodram CX400 250 GB SATA3";
            Computer.Price += 149.99;
        }

        public override void BuildScreen() {
            Computer.Screen = "BenQ GW2270H (1920x1080)";
            Computer.Price += 369.00;
        }
    }
}