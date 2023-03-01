using BPKBBackendProject.Models.Bpkb;

namespace BPKBBackendProject.Interfaces
{
    public interface IBpkbRepository
    {
        void addBpkb(InsertBpkb model);
    }
}
