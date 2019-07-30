using Moto.Common.Entities;
using Moto.Common.Interfaces;
using Moto.Dal;
using System.Collections.Generic;
using System.Linq;

namespace Moto.Core
{
    public class MemberService
    {
        IRepository<Member> memberRepository;

        public MemberService()
        {
            memberRepository = new MemberRepository();
        }

        //Read
        public IEnumerable<Member> GetAll()
        {
            var result = memberRepository.FindAll();
            return result;
        }

        //Add 
        public bool Add(Member member)
        {
            bool result = false;
            var chk = memberRepository.GetById(member.id);
            if (chk == null)
            {
                memberRepository.Add(member);
                result = true;
            }
            return result;
        }

        //Delete
        public bool Delete(int id)
        {
            bool result = false;
            var chk = memberRepository.GetById(id);

            if (chk == null)
            {
                //to do something
            }
            else
            {
                memberRepository.Remove(chk);
                result = true;
            }
            return result;
        }
        //Detail
        public Member Query(int id)
        {
            var member = memberRepository.Find(x => x.id == id).SingleOrDefault();
            return member;
        }

        //Update
        public bool Update(Member member)
        {
            bool result = false;
            var chk = memberRepository.GetById(member.id);
            if (chk == null)
            {
                //to do something
            }
            else
            {
                memberRepository.Update(member);
                result = true;
            }
            return result;
        }

        public bool Auth(Member member)
        {
            bool result = false;
            var chk = memberRepository.Find(x => x.Account == member.Account && x.Password == member.Password).SingleOrDefault();
            if (chk == null)
            {
                //to do something
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}