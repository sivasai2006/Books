import requests
import time

_reltio_auth_url = "https://auth.reltio.com/oauth/"
_user = "Nivedha.Vadivel@bcbsnc.com "
_password = "Marevin!20"
_rest_api_retry_count = 3
_ssl_verify = True
_authToken = "3e64c1bb-eb57-4aed-a802-0660025ddd46"
_refreshToken = "f233eb5b-4d24-42c1-9274-2ed118492a0d"
#_token_expiration = datetime.now()

def reltio_api_authenticate():
    global _authToken, _refreshToken, _token_expiration

    endpoint = "{}token?username={}&password={}&grant_type=password".format(_reltio_auth_url, _user, _password)
    authorization = rest_api_get(endpoint)

    if len(authorization) != 0:
        try:
            _authToken = authorization['access_token']
            _refreshToken = authorization['refresh_token']

            expiration_seconds = authorization['expires_in']
            #_token_expiration = datetime.now() + timedelta(seconds=expiration_seconds)
            #_token_expiration = expiration_seconds

            #print("Expiration: {}\n".format(_token_expiration))
            print("Expiration: {}\n".format(expiration_seconds))
        except KeyError:
            print("Error Description:" + authorization['error_description'] + "\n")
            print("Failure in reltio_api_authenticate()" + "\n")
            raise RuntimeError("Failure in reltio_api_authenticate()")

def rest_api_get(endpoint):
    get_response = ""

    for retry_attempt in range(0, _rest_api_retry_count):
        headers = {"Authorization": "Bearer " + _authToken, "Content-Type": "application/json"}

        # if authenticating, change header
        if _reltio_auth_url in endpoint:
            headers["Authorization"] = "Basic cmVsdGlvX3VpOm1ha2l0YQ=="

        print(endpoint +"\n")
        print(headers + "\n")

        response = requests.get(endpoint, headers=headers, verify=_ssl_verify)

        if response.status_code == 200:
            try:
                get_response = response.json()
            except ValueError:
                print("rest_api_get(): {}\nNo JSON object could be decoded\n[{}] {}"
                      .format(endpoint, response.status_code, response.reason))
                raise
        elif response.status_code == 401:
            if _authToken != "" and "oauth" not in endpoint:
                print("rest_api_get()\n{} - Unauthorized - Sleeping before token refresh".format(endpoint))
                sleep_time = retry_attempt * 5 + 5
                print("rest_api_get()\nSleeping {} second(s)".format(sleep_time))
                time.sleep(sleep_time)
                # reltio_api_refresh_token()
            continue
        elif response.status_code == 504:
            # if last retry, throw exception
            print("rest_api_get(): Gateway Timeout ({})\n{}".format(retry_attempt, endpoint))
            if retry_attempt == _rest_api_retry_count - 1:
                raise Exception("rest_api_get()\n{}: GATEWAY TIMEOUT persisted after {} retries."
                                .format(endpoint, _rest_api_retry_count))
            else:
                # sleep before retrying
                sleep_time = retry_attempt * 5 + 5
                print("rest_api_get()\nSleeping {} second(s)".format(sleep_time))
                time.sleep(sleep_time)
                continue
        else:
            # raise error if unsuccessful status code return
            raise Exception("rest_api_get()\n{}\nGet failed.[{}]{}"
                            .format(endpoint, response.status_code, response.reason))

        break

    return get_response

if __name__ == "__main__":
    reltio_api_authenticate()
