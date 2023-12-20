namespace dailyquiz.Application.Common.Interfaces;

public interface IJwtProvider 
{
    string Generate(string message);
}