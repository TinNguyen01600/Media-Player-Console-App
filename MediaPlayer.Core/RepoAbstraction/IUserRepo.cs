namespace MediaPlayer.Core.RepoAbstraction
{
    public interface IUserRepo
    {
        public bool CreateNewPlaytrack();
        public void AddMediasToPlayTrack();
    }
}