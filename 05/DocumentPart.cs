using System;

namespace Classes
{
    abstract class DocumentPart
    {
        protected string content;

        public abstract string Content { protected get; set; }

        public abstract void Show();
    }
}
