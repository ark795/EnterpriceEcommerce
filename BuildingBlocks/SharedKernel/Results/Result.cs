using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using Serilog;
using System;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BuildingBlocks.SharedKernel.Results;

public class Result<T>
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; }
    public T Value { get; }

    protected Result(bool isSuccess, T value, Error error)
    {
        IsSuccess = isSuccess;
        Value = value;
        Error = error;
    }

    public static Result<T> Success(T value) =>
        new(true, value, Error.None);

    public static Result<T> Failure(Error error) =>
        new(false, default!, error);
}















//من یک.net microservice ecommerce میخواهم کاملا حرفه ای. و از این ها استفاده بکن ddd, masstransit, events, consumers, saga pattern, outbox pattern with masstransit.entityframeworkcore, cqrs, mediatr, integration test, container test, consumer test, end to end test, cancel Command rollback, Monitoring, RabbitMQ UI + Serilog, CI/CD, Retry/Timeout/CircuitBreaker, Saga State UI MassTransit Quartz Dashboard, Jaeger Tracing, Grafana, Zipkin-Compatible, OpenTelemetry, Quartz Scheduler, Monitoring Alerts with Grafana + Prometheus, Kafka, Saga State Machine UI با MongoDb + Hangfire, API Gateway, Kubernetes, Helm Charts, * Health Checks UI, EventStoreDB, Health Checks + Readiness/Liveness Probes, Dashboard Aggregation, Log Aggregation, Service Mesh, Security
//JWT Validation Middleware (already included).

//Add Key Rotation support for tokens.

//Add Rate Limiting / IP Blacklist / Bot Detection – via middleware or API Gateway, Chaos Engineering Tools, Message Archiving / Dead Letter Queue (DLQ) Viewer, Database Monitoring, Error Tracking, Rate Limiting / Throttling, Feature Flags. ایا همه چیز های مهم را پوشش دادم؟ اگر اره پس شروع کنیم فقط لطفا مرحله به مرحله بریم جلو. هیچ فایلی را جا ننداز و structure را به من نشان بده. و همه چیز را به من نشان بده لطفا
