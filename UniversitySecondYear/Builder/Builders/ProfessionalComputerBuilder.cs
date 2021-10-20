using ArchotekturaLabTwo.Models;

namespace ArchotekturaLabTwo.Builders {
    public class ProfessionalComputerBuilder : ComputerBuilder {
        public ProfessionalComputerBuilder() {
            Computer = new Computer("profesjonalny");
        }

        public override void BuildMotherboard() {
            Computer.MotherBoard = "Supermicro MBD X11DPH";
            Computer.Price += 2755.30;
        }

        public override void BuildProcessor() {
            Computer.Processor = "Intel Xeon Gold 5120";
            Computer.Price += 7999.00;
        }

        public override void BuildDrive() {
            Computer.Drive = "Seagate Skyhawk 14TB 3.5";
            Computer.Price += 2101.75;
        }

        public override void BuildScreen() {
            Computer.Screen = "Eizo CG319X (4096x2160)";
            Computer.Price += 20749.00;
        }
    }
}