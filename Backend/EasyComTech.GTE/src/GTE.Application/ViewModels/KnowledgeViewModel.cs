using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.ViewModels
{
    public class KnowledgeViewModel
    {
        public KnowledgeViewModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public int LevelOfKnowledgeIonic { get; set; }

        public int LevelOfKnowledgeAndroid { get; set; }

        public int LevelOfKnowledgeIOS { get; set; }

        public int LevelOfKnowledgeHTML { get; set; }

        public int LevelOfKnowledgeCSS { get; set; }

        public int LevelOfKnowledgeBootstrap { get; set; }

        public int LevelOfKnowledgeJquery { get; set; }

        public int LevelOfKnowledgeAngularJs { get; set; }

        public int LevelOfKnowledgeJava { get; set; }

        public int LevelOfKnowledgeAspNetMVC { get; set; }

        public int LevelOfKnowledgeC { get; set; }

        public int LevelOfKnowledgeCPlusPlus { get; set; }

        public int LevelOfKnowledgeCake { get; set; }

        public int LevelOfKnowledgeDjango { get; set; }

        public int LevelOfKnowledgeMajento { get; set; }

        public int LevelOfKnowledgePHP { get; set; }

        public int LevelOfKnowledgeWordpress { get; set; }

        public int LevelOfKnowledgePhyton { get; set; }

        public int LevelOfKnowledgeRuby { get; set; }

        public int LevelOfKnowledgeMySQLServer { get; set; }

        public int LevelOfKnowledgeMySQL { get; set; }

        public int LevelOfKnowledgeSalesforce { get; set; }

        public int LevelOfKnowledgePhotoshop { get; set; }

        public int LevelOfKnowledgeIllustrator { get; set; }

        public int LevelOfKnowledgeSEO { get; set; }

        public string OtherLanguageOrFramework { get; set; }

        public string LinkCRUD { get; set; }


        public Guid ProgrammerId { get; set; }
        public ProgrammerViewModel Programmer { get; set; }
    }
}
