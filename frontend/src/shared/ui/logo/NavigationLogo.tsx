import { Link } from 'react-router-dom';
import { Logo } from './Logo';

type NavigationLogoProps = {
    className?: string;
    logoClassName?: string;
    to?: string;
};

export const NavigationLogo = ({ className, logoClassName, to = '/' }: NavigationLogoProps) => (
    <Link
        className={className}
        to={to}
    >
        <Logo className={logoClassName} />
    </Link>
);
