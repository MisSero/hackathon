import { GosuslugiIcon } from '@/shared/ui/icons/GosuslugiIcon';
import { YaIcon } from '@/shared/ui/icons/YaIcon';
import './ExternalAuthBar.scss';
import { VkIcon } from '@/shared/ui/icons/VkIcon';

export const ExternalAuthBar = () => (
    <div className="externalAuthBar">
        <YaIcon />
        <GosuslugiIcon />
        <VkIcon />
    </div>
);
