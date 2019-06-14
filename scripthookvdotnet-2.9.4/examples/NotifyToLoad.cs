using GTA;

class NotifyToLoad : Script
{
    private readonly string modName = "Examples";

    public NotifyToLoad() => UI.Notify("~b~~h~" + modName + "~h~~w~ - Loaded");
}
