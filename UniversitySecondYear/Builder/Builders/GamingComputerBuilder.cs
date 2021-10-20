using System;
using System.Collections.Generic;
using System.Text;
using ArchotekturaLabTwo.Models;

namespace ArchotekturaLabTwo.Builders {
    public class GamingComputerBuilder : ComputerBuilder {
        public GamingComputerBuilder() {
            Computer = new Computer("gamingowy");
        }
        public override void BuildMotherboard() {
            Computer.MotherBoard = "Gigabyte X570 Aorus Elite";
            Computer.Price += 895.60;
        }

        public override void BuildProcessor() {
            Computer.Processor = "Intel i7 9700K";
            Computer.Price += 1829.00;
        }

        public override void BuildDrive() {
            Computer.Drive = "Samsung 970 EVO Plus 2TB M.2";
            Computer.Price += 2028.45;
        }

        public override void BuildScreen() {
            Computer.Screen = "HP Z4W65A4 (3840x1600)";
            Computer.Price += 4927.75;
        }
    }
}