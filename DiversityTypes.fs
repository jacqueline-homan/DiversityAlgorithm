namespace Diversity

open System.Collections

module Types =

    type Coder =
        | Beginner
        | Junior
        | Mid
        | Senior

    type Marginalized =
        | LGBTQA
        | EducationalDisadvantage
        | HTSurvivor
        | OverAge40
        | NonWhiteNonAsian
        | Disabled
        | Poor
        | Female
        | CriminalRecord

    type CoderStatus =
        | Unemployed of Coder
        | NotworkingInDev of Coder
        | EmployedInDev of Coder

    type Solutions =
        | OpenSourceStipend
        | Internship
        | Apprenticeship
        | GiftedComputer
        | FullScholarship
        | ProActiveHiring

    type LearningPath =
        | College
        | DevBootcamp
        | SelfTaught
        | OnlineTutorials
        | PersonalMentorOTJ

    type AcademicLevel =
        | HighSchoolOrLess
        | TradeSchool
        | SomeCollege
        | Bachelors
        | Masters
        | Doctorate

    and DegreeType =
        | ComputerScience of AcademicLevel
        | OtherSTEM of AcademicLevel
        | Other of AcademicLevel

    type DesiredOutcome = CoderStatus of Coder * Solutions * string