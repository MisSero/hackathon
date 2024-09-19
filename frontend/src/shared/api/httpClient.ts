import axios from 'axios';

const createHttpClient = () => {
    const instance = axios.create();

    instance.interceptors.request.use(async (request) => {
        const jwt = localStorage.getItem('jwtToken');

        if (jwt) {
            request.headers.Authorization = `Bearer ${JSON.parse(jwt).data}`;
        }

        return request;
    });

    instance.interceptors.response.use(
        (response) => {
            return response;
        },
        (error) => {
            console.log(`error`, error);
        },
    );

    return instance;
};

export const httpClient = createHttpClient();
