using Data.Entities;

namespace WebApp.Models.MembersModels
{
    public class MembersViewModel
    {
        public AddMemberModel AddMember { get; set; } = new AddMemberModel();
        public EditMemberModel EditMember { get; set; } = new EditMemberModel();
        public bool ShowAddModal { get; set; } = false;
        public bool ShowEditModal { get; set; } = false;
        public List<MemberEntity> Members { get; set; } = new();
    }
}
