﻿using BeanSceneReservationSystem.MongoDbApi.Models;

namespace BeanSceneReservationSystem.MongoDbApi.Services
{
    public interface IOrderService
    {
        List<Order> Get();
        Order Get(string id);
        Order Create(Order order);
        void Update(string id, Order order);
        void Delete(string id);
    }
}
