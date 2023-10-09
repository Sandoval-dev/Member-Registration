using MemberRegistiration.Business.Abstract;
using MemberRegistiration.MvcWebUI.Fİlters;
using MemberRegistiration.MvcWebUI.Models;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberRegistiration.MvcWebUI.Controllers
{
    public class MemberController : Controller
    {

        private IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        // GET: Member
        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }

        [HttpPost]
        [ExceptionHandler]
        public ActionResult Add(Member member)
        {
            _memberService.Add(member);
            return View(new MemberAddViewModel());
        }
    }
}