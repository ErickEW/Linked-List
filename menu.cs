using System;
using System.Collections.Generic;

namespace Linked_List
{
     class Menu
    {
        List<int> MenuOpciones = new List<int>(new int[] {1, 2});
        List<int> Pisos = new List<int>(new int[] {1, 2, 3, 4});

        private Elevador elevador = new Elevador();


        public void voz() {
            System.Console.WriteLine("Hola, Binvenido");
            System.Console.WriteLine();
        }

        private void opciones() {
            System.Console.WriteLine("1) Pedir elevador");
            System.Console.WriteLine("2) Marcar piso");
        }

        private void despedida() {
            System.Console.WriteLine("¡Gracias por utilizar este elevador! ¡Hasta luego!");
        }

        private int pedirPiso(List<int> valida) {
            int numero = 0;
            bool invalida = false;

            while(invalida) {
                System.Console.WriteLine("Selecciona una opción:");
                string opcionSeleccionada = System.Console.ReadLine();


                try {
                    numero = Convert.ToInt32(opcionSeleccionada);
                    invalida = valida.Contains(numero);
                } catch (System.Exception) {
                    invalida = false;
                }


                if (invalida)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return numero;
        }

        private void pedirElevador() {
            System.Console.WriteLine("¿En qué piso estamos?");
            int pisoDestino = pedirPiso(Pisos);
            elevador.PedirElevador(pisoDestino);
        }

        private void IrAPiso() {
            System.Console.WriteLine("¿A qué piso quieres ir?");
            int pisoDestino = pedirPiso(Pisos);
            elevador.IrAPiso(pisoDestino);
        }
       
    }
}
// using System;
// using System.Collections.Generic;

// namespace elevator
// {
//      class Menu
//     {
//         /*
//         ¡Bienvenido al elevador!
//         1) Pedir elevador
//         2) Ir a piso
//         9) Salir
//         */

//         private const int MAIN_MENU_EXIT_OPTION = 9;
//         private const int GO_BACK_OPTION = 9;

//         List<int> mainMenuOptions = new List<int>(new int[] {1, 2, 9});
//         List<int> elevadorOptions = new List<int>(new int[] {1, 2, 3, 4, 5, 6, 7});

//         private Elevator elevator = new Elevator();


//         private void DisplayWelcomeMessage() {
//             System.Console.WriteLine("¡Bienvenido al elevador!");
//             System.Console.WriteLine();
//         }

//         private void DisplayMainMenuOptions() {
//             System.Console.WriteLine("1) Pedir elevador");
//             System.Console.WriteLine("2) Ir a piso");
//             System.Console.WriteLine();
//             System.Console.WriteLine("9) Salir");
//         }

//         private void DisplayByeMessage() {
//             System.Console.WriteLine("¡Gracias por utilizar este elevador! ¡Hasta luego!");
//         }

//         private int RequestOption(List<int> validOptions) {
//             int userInputAsInt = 0;
//             bool isUserInputValid = false;

//             //Mientras no haya una respuesta válida...
//             while(!isUserInputValid) {
//                 System.Console.WriteLine("Selecciona una opción:");
//                 string userInput = System.Console.ReadLine();


//                 try {
//                     userInputAsInt = Convert.ToInt32(userInput);
//                     isUserInputValid = validOptions.Contains(userInputAsInt);
//                 } catch (System.Exception) {
//                     isUserInputValid = false;
//                 }


//                 if (!isUserInputValid)
//                 {
//                     System.Console.WriteLine("La opción seleccionada no es válida.");
//                 }
//             }

//             return userInputAsInt;
//         }

//         private void PedirElevador() {
//             System.Console.WriteLine("¿En qué piso te encuentras?");
//             int pisoDestino = RequestOption(elevadorOptions);
//             elevator.PedirElevador(pisoDestino);
//         }

//         private void IrAPiso() {
//             System.Console.WriteLine("¿A qué piso quieres ir?");
//             int pisoDestino = RequestOption(elevadorOptions);
//             elevator.IrAPiso(pisoDestino);
//         }

//         public void Display() {
//             int selectedOption = 0;

//             DisplayWelcomeMessage();

//             while (selectedOption != MAIN_MENU_EXIT_OPTION) {
//                 DisplayMainMenuOptions();

//                 selectedOption = RequestOption(mainMenuOptions);

//                 switch (selectedOption)
//                 {
//                     case 1: //Pedir elevador
//                         PedirElevador();
//                         break;
//                     case 2: //Ir a piso
//                         IrAPiso();
//                         break;
//                     // default:
//                 }
//             }

//             DisplayByeMessage();

//         }
       
//     }
// }