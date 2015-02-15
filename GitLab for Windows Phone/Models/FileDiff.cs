using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GitLab_for_Windows_Phone.Models
{
    [DataContract]
    public class FileDiff
    {
        public enum LineTypes
        {
            Untouched,
            AreaInfo,
            Added, 
            Removed
        }

        public enum FileDiffTypes
        {
            Edited, 
            Created,
            Removed
        }

        public class Line
        {
            public LineTypes Type { get; private set; }

            public string Text { get; private set; }


            public Line(string text)
            {
                Text = text;

                if (Text != null)
                {
                    if (Text.StartsWith("+"))
                    {
                        Type = LineTypes.Added;
                    }
                    else if (Text.StartsWith("-"))
                    {
                        Type = LineTypes.Removed;
                    }
                    else if (Text.StartsWith(AreaInfoLineDelimiter) && Text.EndsWith(AreaInfoLineDelimiter))
                    {
                        Type = LineTypes.AreaInfo;
                    }
                    else
                    {
                        Type = LineTypes.Untouched;
                    }
                }
            }

            public Line(string text, LineTypes forcedType)
            {
                Text = text;
                Type = forcedType;
            }
        }

        public FileDiffTypes Type
        {
            get
            {
                if (WasNew)
                {
                    return FileDiffTypes.Created;
                }

                if (WasDeleted)
                {
                    return FileDiffTypes.Removed;
                }

                return FileDiffTypes.Edited;
            }
        }

        [DataMember(Name = "diff")]
        public string Content { get; set; }

        [DataMember(Name = "new_path")]
        public string NewPath { get; set; }

        [DataMember(Name = "old_path")]
        public string OldPath { get; set; }

        [DataMember(Name = "renamed_file")]
        public bool WasRenamed { get; set; }

        [DataMember(Name = "deleted_file")]
        public bool WasDeleted { get; set; }

        [DataMember(Name = "new_file")]
        public bool WasNew { get; set; }

        [IgnoreDataMember]
        public string FileName { get { return WasDeleted ? OldPath : NewPath; } }

        private const string AreaInfoLineDelimiter = "@@";
        private const char NewLine = '\n';

        private List<Line> _lines;
        [IgnoreDataMember]
        public List<Line> Lines
        {
            get
            {
                if (_lines == null)
                {
                    if (WasDeleted || WasNew)
                    {
                        var type = WasDeleted ? LineTypes.Removed : LineTypes.Added;
                        _lines = Content.Split(NewLine).Skip(3).Select(l => new Line(l.Substring(1), type)).ToList();
                    }
                    else
                    {
                        _lines = Content.Split(NewLine).Skip(2).Select(l => new Line(l)).ToList();
                    }
                }

                return _lines;
            }
        }
    }
}
