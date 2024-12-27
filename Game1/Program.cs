using SFML.Graphics;
using SFML.System;
using SFML.Window;
//using static System.Net.Mime.MediaTypeNames;

namespace Jogo{
    class Program{
        static void Main(string[] args){
            // Cria uma janela com tamanho 800x600 e título "Minha Janela Preta"
            RenderWindow window = new RenderWindow(new VideoMode(800, 600), "HonorNDuty");

            // Define o fundo preto
            window.Clear(Color.Black);

            // Evento para fechar a janela ao pressionar o botão de fechar
            window.Closed += (sender, e) => window.Close();

            // Carrega a fonte
            Font font = new Font("D:\\C#\\Game1\\Game1\\a_love_of_thunder\\A Love of Thunder.ttf"); // Certifique-se de que o arquivo está na mesma pasta ou forneça o caminho correto

            //Draw UI
            //kill
            RectangleShape BoxPlay = new RectangleShape(new SFML.System.Vector2f(300, 75));
            BoxPlay.FillColor = Color.White;
            BoxPlay.Position = new SFML.System.Vector2f(50, 200);

            SFML.Graphics.Text textKill = new SFML.Graphics.Text("Kill", font);
            textKill.CharacterSize = 76; // Tamanho da fonte
            textKill.FillColor = Color.Black; // Cor do texto
            textKill.Position = new SFML.System.Vector2f(120, 190); // Posição do texto sobre o botão

            //inventory
            RectangleShape BoxInventory = new RectangleShape(new SFML.System.Vector2f(200, 50));
            BoxInventory.FillColor = Color.White;
            BoxInventory.Position = new SFML.System.Vector2f(50, 300);

            SFML.Graphics.Text textInventory = new SFML.Graphics.Text("Inventory", font);
            textInventory.CharacterSize = 24;
            textInventory.FillColor = Color.Black;
            textInventory.Position = new SFML.System.Vector2f(75, 310);

            //settings button
            RectangleShape BoxSettings = new RectangleShape(new SFML.System.Vector2f(200, 50));
            BoxSettings.FillColor = Color.White;
            BoxSettings.Position = new SFML.System.Vector2f(50, 375);

            SFML.Graphics.Text textSettings = new SFML.Graphics.Text("Settings", font);
            textSettings.CharacterSize = 24;
            textSettings.FillColor = Color.Black;
            textSettings.Position = new SFML.System.Vector2f(75, 385);

            //exit button
            RectangleShape BoxExit = new RectangleShape(new SFML.System.Vector2f(200, 50));
            BoxExit.FillColor = Color.White;
            BoxExit.Position = new SFML.System.Vector2f(50, 450);

            SFML.Graphics.Text textExit = new SFML.Graphics.Text("Exit", font);
            textExit.CharacterSize = 24;
            textExit.FillColor = Color.Black;
            textExit.Position = new SFML.System.Vector2f(100, 460);


            // Loop principal
            while (window.IsOpen) { 
                // Processa eventos
                window.DispatchEvents();

                //fundo
                window.Clear(Color.Black);





                // Actions
                // Verifica a posição do mouse e muda cor
                Vector2i mousePosition = Mouse.GetPosition(window);
                FloatRect boxBoundsPlay = BoxPlay.GetGlobalBounds(); // Play
                if (boxBoundsPlay.Contains(mousePosition.X, mousePosition.Y))
                {
                    BoxPlay.FillColor = Color.Red; // Muda a cor da caixa
                }
                else
                {
                    BoxPlay.FillColor = Color.White; // Volta à cor original
                }

                FloatRect BoxBoundsInventory = BoxInventory.GetGlobalBounds(); //pega coords dda box inv
                if (BoxBoundsInventory.Contains(mousePosition.X, mousePosition.Y))//se mouse na box inv
                {
                    BoxInventory.FillColor = Color.Red; // Muda a cor da caixa
                }
                else
                {
                    BoxInventory.FillColor = Color.White; // Volta à cor original
                }

                FloatRect BoxBoundsSettings = BoxSettings.GetGlobalBounds(); //pega coords dda box inv
                if (BoxBoundsSettings.Contains(mousePosition.X, mousePosition.Y))//se mouse na box inv
                {
                    BoxSettings.FillColor = Color.Red; // Muda a cor da caixa
                }
                else
                {
                    BoxSettings.FillColor = Color.White; // Volta à cor original
                }

                FloatRect BoxBoundsExit = BoxExit.GetGlobalBounds(); //pega coords dda box inv
                if (BoxBoundsExit.Contains(mousePosition.X, mousePosition.Y))//se mouse na box inv
                {
                    BoxExit.FillColor = Color.Red; // Muda a cor da caixa
                                                   // Fecha a janela se o botão esquerdo do mouse for clicado
                    if (Mouse.IsButtonPressed(Mouse.Button.Left))
                    {
                        window.Close();
                    }
                }
                else
                {
                    BoxExit.FillColor = Color.White; // Volta à cor original
                }






                // Renderiza(desenha/draw)
                window.Draw(BoxPlay);
                window.Draw(textKill);

                window.Draw(BoxInventory);
                window.Draw(textInventory);

                window.Draw(BoxSettings);
                window.Draw(textSettings);

                window.Draw(BoxExit);
                window.Draw(textExit);

                // Atualiza a tela, logo, precisa vir no final
                window.Display();
            }

        }
    }


}

