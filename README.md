# Get Blood Pressure Readings

The fluctuations are not very realistic. The ranges have come from medical websites such as 
[Heart Research UK](https://heartresearch.org.uk/). The heart rates came from
[Cleveland Clinic](https://my.clevelandclinic.org/health/diagnostics/17402-pulse--heart-rate) 

Whether it's to use for api testing or to use as a mock server for an app
the readings should be good enough to get some data to play with.


## Using the API

Call with `GET` to `api/GetBPR?age={AGE}&quantity={QTY}&risk={RISK}` to get a list of readings.

Age and qty should be easy to fathom out. Risk can be one of the following:

1. Normal
2. Elevated
3. High

The numbers are what are used for the risk parameter.

e.g. `api/GetBPR?age=90&quantity=30&risk=2` will return 30 readings for a 90 year old with elevated risk.


## Success

If the api is successfull it returns the following format.

`
{
    "status": {
        "statusCode": 200,
        "statusMessage": "OK",
        "statusErrors": []
    },
    "data": [
        {
            "readingDate": "2023-08-04T10:35:00",
            "sys": 143,
            "dia": 72,
            "pulse": 129
        }
    ]
}
`

## Errors

If the api encounters an error through incorrect parameters it will return the following format.

`
{
    "status": {
        "statusCode": 400,
        "statusMessage": "Bad Request",
        "statusErrors": [
            "A value for parameter age is missing",
            "A value for parameter qty is missing",
            "Parameter risk is missing or incorrect. Valid values for risk are 1, 2, 3"
        ]
    },
    "data": null
}
`
