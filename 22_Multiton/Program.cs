﻿using _22_Multiton;

Camera camera1 = Camera.GetCamera("NIKON");
Camera camera2 = Camera.GetCamera("NIKON");
Camera camera3 = Camera.GetCamera("CANON");
Camera camera4 = Camera.GetCamera("CANON");

Console.WriteLine(camera1.Id);
Console.WriteLine(camera2.Id);
Console.WriteLine(camera3.Id);
Console.WriteLine(camera4.Id);