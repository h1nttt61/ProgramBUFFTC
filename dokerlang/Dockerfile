FROM python:3.13-slim

WORKDIR /app

COPY Fibonacci.py .
COPY testFibonacci.py .

RUN pip install --no-cache-dir pytest

CMD ["pytest", "-q"]