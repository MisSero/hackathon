import { loginRequest, signupRequest, userInfoRequest } from '@/shared/api/methods';
import { LoginRequest, SignupRequest } from '@/shared/api/types';
import { atom, reatomAsync, reatomResource, withDataAtom, withErrorAtom } from '@reatom/framework';
import { withLocalStorage } from '@reatom/persist-web-storage';

const jwtTokenAtom = atom('', 'jwtTokenAtom').pipe(withLocalStorage('jwtToken'));

export const loginAction = reatomAsync(async (ctx, data: LoginRequest) => {
    const resp = await ctx.schedule(() => loginRequest(data));

    jwtTokenAtom(ctx, resp.jwtToken);

    return resp;
}, 'loginAction').pipe(withErrorAtom());

export const userInfoResource = reatomResource(async (ctx) => {
    const token = ctx.spy(jwtTokenAtom);

    if (!token) return null;

    return await ctx.schedule(() => userInfoRequest());
}, 'userInfoResource').pipe(withDataAtom(), withErrorAtom());

export const signupAction = reatomAsync(
    async (ctx, data: SignupRequest) => await ctx.schedule(() => signupRequest(data)),
    'signupAction',
).pipe(withErrorAtom());
