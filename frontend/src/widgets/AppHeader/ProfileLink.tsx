import { userInfoResource } from '@/entities/User';
import { UserIcon } from '@/shared/ui/icons';
import { reatomComponent } from '@reatom/npm-react';
import { Link } from 'react-router-dom';

export const ProfileLink = reatomComponent(({ ctx }) => {
    const user = ctx.spy(userInfoResource.dataAtom);

    if (!user) {
        return (
            <Link
                className="unsettedLink actionLink"
                to="/login"
            >
                Войти
                <UserIcon />
            </Link>
        );
    }

    return (
        <Link
            className="unsettedLink actionLink"
            to="/profile"
        >
            {user.userName}
            <UserIcon />
        </Link>
    );
}, 'ProfileLink');
