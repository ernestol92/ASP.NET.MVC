using Business.DTOs;
using Business.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.MembersModels;

namespace WebApp.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        public async  Task<IActionResult> TeamMembers()
        {
            var membersViewModel = new MembersViewModel();
            var members = await _memberService.GetAllMembersAsync();
            membersViewModel.Members = members.ToList();
            return View(membersViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> AddTeamMember(MembersViewModel formData, int birthYear, int birthMonth, int birthDay) 
        {
            ModelState.Remove("EditMember.Id");
            ModelState.Remove("EditMember.FirstName");
            ModelState.Remove("EditMember.LastName");
            ModelState.Remove("EditMember.Email");
            ModelState.Remove("EditMember.PhoneNumber");
            ModelState.Remove("EditMember.Role");
            ModelState.Remove("EditMember.Address");
            ModelState.Remove("EditMember.DateOfBirth");

            formData.ShowEditModal = false;
            if (formData.AddMember == null || !ModelState.IsValid)
            {
                formData.ShowAddModal = true;
                var members = await _memberService.GetAllMembersAsync();
                formData.Members = members.ToList();
                return View("TeamMembers", formData);
            }
            
            formData.ShowAddModal = false;
            var dto = new MemberDto
            {
                FirstName = formData.AddMember.FirstName,
                LastName = formData.AddMember.LastName,
                Email = formData.AddMember.Email,
                PhoneNumber = formData.AddMember.PhoneNumber,
                Role = formData.AddMember.Role,
                Address = formData.AddMember.Address,
                DateOfBirth = new DateTime(birthYear, birthMonth, birthDay)
            };
            await _memberService.CreateMemberAsync(dto);

            return RedirectToAction("TeamMembers");

        }

        [HttpPost]
        public async Task<IActionResult> EditTeamMember(MembersViewModel formData, int birthYear, int birthMonth, int birthDay)
        {
            ModelState.Remove("AddMember.FirstName");
            ModelState.Remove("AddMember.LastName");
            ModelState.Remove("AddMember.Email");
            ModelState.Remove("AddMember.PhoneNumber");
            ModelState.Remove("AddMember.Role");
            ModelState.Remove("AddMember.Address");
            ModelState.Remove("AddMember.DateOfBirth");

            formData.ShowAddModal = false;
            
            if (formData.EditMember == null || !ModelState.IsValid)
            {
                formData.ShowEditModal = true;
                var members = await _memberService.GetAllMembersAsync();
                formData.Members = members.ToList();
                return View("TeamMembers", formData);
            }

            
            formData.ShowEditModal = false;

            var dto = new MemberDto
            {
                FirstName = formData.EditMember.FirstName,
                LastName = formData.EditMember.LastName,
                Email = formData.EditMember.Email,
                PhoneNumber = formData.EditMember.PhoneNumber,
                Role = formData.EditMember.Role,
                Address = formData.EditMember.Address,
                DateOfBirth = new DateTime(birthYear, birthMonth, birthDay)
            };

            await _memberService.UpdateMemberAsync(formData.EditMember.Id, dto);
            return RedirectToAction("TeamMembers");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTeamMember(int id) 
        {
            await _memberService.DeleteMemberAsync(id);
            return RedirectToAction("TeamMembers");
        }
    }
}
