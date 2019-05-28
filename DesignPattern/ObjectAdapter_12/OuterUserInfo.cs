namespace DesignPattern.ObjectAdapter_12
{
    class OuterUserInfo:IUserInfo
    {
        private IOuterUserBaseInfo _outerUserBaseInfo = null;
        private IOuterUserHomeInfo _outerUserHomeInfo = null;
        private IOuterUserOfficeInfo _outerUserOfficeInfo = null;

        private string userName = null;
        private string phone = null;
        private string job = null;

        public OuterUserInfo(IOuterUserBaseInfo outerUserBaseInfo, IOuterUserHomeInfo outerUserHomeInfo,
            IOuterUserOfficeInfo outerUserOfficeInfo)
        {
            _outerUserBaseInfo = outerUserBaseInfo;
            _outerUserHomeInfo = outerUserHomeInfo;
            _outerUserOfficeInfo = outerUserOfficeInfo;

            userName = outerUserBaseInfo.GetUserBaseInfo()["UserName"];
            phone = outerUserHomeInfo.GetUserHomeInfo()["Phone"];
            job = outerUserOfficeInfo.GetUserOfficeInfo()["Job"];
        }

        public string GetUserName()
        {
            return userName;
        }

        public string GetHomeAddress()
        {
            return phone;
        }

        public string GetJobPosition()
        {
            return job;
        }
    }
}
