import clsx from 'clsx';
import { ReactNode } from 'react';
import './FormSection.scss';

type FormSection = {
    className?: string;
    title: string;
    children: ReactNode;
};

export const FormSection = ({ className, title, children }: FormSection) => {
    return (
        <section className={clsx('formSection', className)}>
            <h2 className="formSection__title">{title}</h2>
            {children}
        </section>
    );
};
