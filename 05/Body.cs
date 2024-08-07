﻿using System;

namespace Classes
{
    class Body : DocumentPart
    {
        public override string Content
        {
            protected get
            {
                if (content != null)
                    return content;
                else
                    return "Тіло документа відсутнє.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
