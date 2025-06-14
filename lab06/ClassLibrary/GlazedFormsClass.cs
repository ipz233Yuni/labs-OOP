using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazedForms
{
    public class GlazedFormsClass
    {
        private double singlechamber_wood = 0.25;
        private double twochamber_wood = 0.30;
        private double singlechamber_metal = 0.05;
        private double twochamber_metal = 0.10;
        private double singlechamber_metal_plastic = 0.15;
        private double twochamber_metal_plastic = 0.20;
        private double cost_of_sill = 35.00;

        public double Calculate(int material, int typeofwindow, double width, double height, bool needWindowSill)
        {
            double result = 0;

            switch (typeofwindow)
            {
                case 1:
                    switch (material)
                    {
                        case 1:
                            result = singlechamber_wood * width * height;
                            break;
                        case 2:
                            result = width * height * singlechamber_metal;
                            break;
                        case 3:
                            result = width * height * singlechamber_metal_plastic;
                            break;
                    }
                    break;
                case 2:
                    switch (material)
                    {
                        case 1:
                            result = twochamber_wood * width * height;
                            break;
                        case 2:
                            result = twochamber_metal * width * height;
                            break;
                        case 3:
                            result = twochamber_metal_plastic * width * height;
                            break;
                    }
                    break;
            }

            if (needWindowSill)
            {
                result += cost_of_sill;
            }

            return result;
        } 
    }
}


