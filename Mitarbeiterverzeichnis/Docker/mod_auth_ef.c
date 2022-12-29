#include "httpd.h"
#include "http_config.h"
#include "http_core.h"
#include "http_log.h"
#include "http_protocol.h"
#include "apr_strings.h"
#include "apr_tables.h"

module AP_MODULE_DECLARE_DATA auth_ef_module;

static apr_status_t auth_ef_cleanup(void *);

static int auth_ef_check_auth(request_rec *);

static int auth_ef_check_auth(request_rec *r)
{
    // Get the username and password from the request headers
    const char *username = apr_table_get(r->headers_in, "Username");
    const char *password = apr_table_get(r->headers_in, "Password");

    // Connect to the database using Entity Framework
    using (var db = new exstructaContext())
    {
        // Query the database for a matching username and password
        var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

        if (user != null)
        {
            // Login successful
            return OK;
        }
        else
        {
            // Login failed
            return HTTP_UNAUTHORIZED;
        }
    }
}

static apr_status_t auth_ef_cleanup(void *data)
{
    // TODO: Clean up any resources used by the authentication module
    return APR_SUCCESS;
}

module AP_MODULE_DECLARE_DATA auth_ef_module =
{
    STANDARD20_MODULE_STUFF,
    NULL,
    NULL,
    NULL,
    NULL,
    NULL,
    auth_ef_check_auth,
    NULL
};
