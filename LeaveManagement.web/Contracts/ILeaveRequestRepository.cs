using LeaveManagement.web.Data;
using LeaveManagement.web.Models;

namespace LeaveManagement.web.Contracts
{
    public interface  ILeaveRequestRepository: IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM requestCreateVM);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task CancelLeaveRequest(int leaveRequestId);
    }
}
