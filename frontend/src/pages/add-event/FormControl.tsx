import clsx from 'clsx';
import { ReactNode } from 'react';
import './FormControl.scss';

type FormControlProps = {
    className?: string;
    label: string;
    required?: boolean;
    children: ReactNode;
};

export const FormControl = ({ label, children, className, required = false }: FormControlProps) => (
    <label className={clsx('formControl', className)}>
        <span className="formControl__label">{`${label}${required ? ' *' : ''}`}</span>
        {children}
    </label>
);
