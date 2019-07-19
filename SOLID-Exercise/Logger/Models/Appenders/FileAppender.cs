using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.Appenders
{
    public class FileAppender : IAppender
    {
        private int messagesAppeneded;

        private FileAppender()
        {
            this.messagesAppeneded = 0;
        }

        public FileAppender(ILayout layout, Level level, IFile file)
            : this()
        {
            this.Layout = layout;
            this.Level = level;
            this.File = file;
        }
        public ILayout Layout { get; private set; }

        public Level Level { get; private set; }

        public IFile File { get; private set; }

        public void Append(IError error)
        {
            string formattedMessage = this.File.Write(this.Layout, error) + Environment.NewLine;

            System.IO.File.AppendAllText(this.File.Path, formattedMessage);
            messagesAppeneded++;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString()}>, Messages appended: {this.messagesAppeneded} File Size: {this.File.Size}";
        }
    }
}
