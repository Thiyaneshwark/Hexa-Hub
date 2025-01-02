﻿using Hexa_Hub.DTO;
using static Hexa_Hub.Models.MultiValues;

namespace Hexa_Hub.Interface
{
    public interface IServiceRequest
    {
        Task<List<ServiceClassDto>> GetAllServiceRequests();
        Task<ServiceRequest?> GetServiceRequestById(int id);
        Task<ServiceClassDto?> GetServiceById(int id);
        Task AddServiceRequest(ServiceRequest serviceRequest);
        Task<ServiceRequest> UpdateServiceRequest(ServiceRequest existingRequest);
        Task DeleteServiceRequest(int id);
        Task Save();
        Task<IEnumerable<ServiceRequestDto>> GetServiceReqByStatus(ServiceReqStatus serviceReqStatus);
        //Task<List<ServiceRequest>> GetServiceRequestsByUserId(int userId);
        Task<List<ServiceClassDto>> GetServiceRequestsByUserId(int userId);

    }

}
