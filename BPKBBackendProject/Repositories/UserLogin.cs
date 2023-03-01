using AutoMapper;
using BPKBBackendProject.Interfaces;
using BPKBBackendProject.Models.Login;
using BPKBBackendProject.Models;
using BPKBBackendProject.Models.Bpkb;

namespace BPKBBackendProject.Repositories
{
    public class UserLogin : IUserLogin
    {
        private DataContext _context;
        private IJwtUtils _jwtUtils;
        private readonly IMapper _mapper;

        public UserLogin(
            DataContext context,
            IJwtUtils jwtUtils,
            IMapper mapper)
        {
            _context = context;
            _jwtUtils = jwtUtils;
            _mapper = mapper;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _context.Users.SingleOrDefault(x => x.user_name == model.user_name);

            // validate
            if (user == null)
                throw new AppException("Username or password is incorrect");

            // authentication successful
            var response = _mapper.Map<AuthenticateResponse>(user);
            response.Token = _jwtUtils.GenerateToken(user);
            return response;
        }

        public void Register(RegisterRequest model)
        {
            // validate
            if (_context.Users.Any(x => x.user_name == model.user_name))
                throw new AppException("Username '" + model.user_name + "' is already taken");

            // map model to new user object
            var user = _mapper.Map<ms_user>(model);

            // hash password
            //this is bad, don't try this in real project :)
            user.password = (model.password);

            // save user
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
